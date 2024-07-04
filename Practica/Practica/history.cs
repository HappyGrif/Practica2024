using GMap.NET.MapProviders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practica
{
    internal class history
    {
        public DateTime Date { get; set; }
        public string Cur_ID { get; set; }
        public double Cur_OfficialRate { get; set; }
     


        static public Chart chart1 = new Chart();


        public async void HistoryEx( int x)
        {

            DateTime dateOneWeekAgo = DateTime.Now.AddDays(-x);
            DateTime Now = DateTime.Now;
            string firstDate = dateOneWeekAgo.ToString("yyyy-MM-dd");
            string secondDate = Now.ToString("yyyy-MM-dd");
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            var chartAreaUSD = new ChartArea("USD");
            var chartAreaEUR = new ChartArea("EUR");
            var chartAreaRUB = new ChartArea("RUB");
            var chartAreaCNY = new ChartArea("CNY");
            
            chart1.ChartAreas.Add(chartAreaUSD);
            chart1.ChartAreas.Add(chartAreaEUR);
            chart1.ChartAreas.Add(chartAreaRUB);
            chart1.ChartAreas.Add(chartAreaCNY);
            chart1.ChartAreas[0].AxisY.Minimum = 3;
            chart1.ChartAreas[1].AxisY.Minimum = 3;
            chart1.ChartAreas[2].AxisY.Minimum = 3;
            chart1.ChartAreas[3].AxisY.Minimum = 4;
            chart1.ChartAreas[0].AlignWithChartArea.ToUpper();
            
            var seriesRUB = new Series("Курс RUB");
            seriesRUB.ChartType = SeriesChartType.Line;
            seriesRUB.ChartArea = "RUB";
            seriesRUB.Color = Color.Red;
            var seriesUSD = new Series("Курс USD");
            seriesUSD.ChartType = SeriesChartType.Line;
            seriesUSD.ChartArea = "USD";
            seriesUSD.Color = Color.Blue;
            var seriesEUR = new Series("Курс EUR");
            seriesEUR.ChartType = SeriesChartType.Line;
            seriesEUR.ChartArea = "EUR";
            seriesEUR.Color = Color.Green;
            var seriesCNY = new Series("Курс CNY");
            seriesCNY.ChartType = SeriesChartType.Line;
            seriesCNY.ChartArea = "CNY";
            seriesCNY.Color = Color.Yellow;
            


            HistoryWeek("https://api.nbrb.by/ExRates/Rates/Dynamics/431?startDate=" + firstDate + "&endDate=" + secondDate, seriesUSD, x);
            HistoryWeek("https://api.nbrb.by/ExRates/Rates/Dynamics/451?startDate=" + firstDate + "&endDate=" + secondDate, seriesEUR, x);
            HistoryWeek("https://api.nbrb.by/ExRates/Rates/Dynamics/456?startDate=" + firstDate + "&endDate=" + secondDate, seriesRUB, x);
            HistoryWeek("https://api.nbrb.by/ExRates/Rates/Dynamics/462?startDate=" + firstDate + "&endDate=" + secondDate, seriesCNY, x);
        }



        private async void HistoryWeek(string apiUrl, Series series, int x)
        {
            

            try
            {

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        var exchangeRate = JsonConvert.DeserializeObject<List<history>>(content);
                        var currentRate = History_week(exchangeRate, x);
                        if (currentRate != null)
                        {
                            
                            for (int i=0; i<currentRate.Count; i++)
                            {
                                string rateDateTime = currentRate[i].Date.ToString("yyyy.MM.dd");
                                if (currentRate[i].Cur_ID == "431")

                                    series.Points.AddXY(rateDateTime, currentRate[i].Cur_OfficialRate);
                                if (exchangeRate[i].Cur_ID == "451")

                                    series.Points.AddXY(rateDateTime, currentRate[i].Cur_OfficialRate);
                                if (exchangeRate[i].Cur_ID == "456")

                                    series.Points.AddXY(rateDateTime, currentRate[i].Cur_OfficialRate);
                                if (exchangeRate[i].Cur_ID == "462") ;
                                    series.Points.AddXY(rateDateTime, currentRate[i].Cur_OfficialRate);
                            }
                            series.BorderWidth = 3;
                            chart1.Series.Add(series);


                        }
                        else
                        {
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Исключение: {ex.Message}");
            }
        }
      


        public List<history> History_week(List<history> history, int x)
        {
            List<history> result = new List<history>();
            DateTime dateOneWeekAgo = DateTime.Now.AddDays(-x);
            DateTime resetTime = new DateTime(dateOneWeekAgo.Year, dateOneWeekAgo.Month, dateOneWeekAgo.Day, 0, 0, 0);

            foreach (var rate in history)
            {
                

                // Проверяем, что дата находится в интервале между resetTime и текущим временем
                if (rate.Date >= dateOneWeekAgo)
                {
                    result.Add(rate);
                }
            }

            return result;
        }


    }
}
