using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    internal class BB
    {

        public string kurs_date_time { get; set; }
        public string USDCARD_in { get; set; }
        public double USDCARD_out { get; set; }
        public string EURCARD_in { get; set; }
        public double EURCARD_out { get; set; }
        public string RUBCARD_in { get; set; }
        public double RUBCARD_out { get; set; }
        public string CNYCARD_in { get; set; }
        public double CNYCARD_out { get; set; }


        static public Label bb_USD_label = new Label();
        static public Label bb_EUR_label = new Label();
        static public Label bb_RUB_label = new Label();
        static public Label bb_CNY_label = new Label();

        public async void BBEx()
        {
            try
            {
                string apiUrl = "https://belarusbank.by/api/kurs_cards";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        var exchangeRates = JsonConvert.DeserializeObject<List<BB>>(content);

                        DateTime currentTime = DateTime.Now;
                        DateTime resetTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0);
                        string formattedTime = resetTime.ToString("yyyy-MM-dd HH:mm:ss");


                        var currentRate = exchangeRates.Find(rate =>
                                                    rate.kurs_date_time == formattedTime);


                        if (currentRate != null)
                        {
                            bb_USD_label.Text = $"Текущий курс USD к BYN: {Math.Round(currentRate.USDCARD_out, 2)}";
                            bb_EUR_label.Text = $"Текущий курс EUR к BYN: {Math.Round(currentRate.EURCARD_out, 2)}";
                            bb_RUB_label.Text = $"Текущий курс RUB к BYN: {Math.Round(currentRate.RUBCARD_out, 2)}";
                            bb_CNY_label.Text = $"Текущий курс CNY к BYN: {Math.Round(currentRate.CNYCARD_out, 2)}";

                        }
                        else
                        {
                            bb_USD_label.Text = "Курс не найден";
                            bb_EUR_label.Text = "Курс не найден";
                            bb_RUB_label.Text = "Курс не найден";
                            bb_CNY_label.Text = "Курс не найден";
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
    }
}
