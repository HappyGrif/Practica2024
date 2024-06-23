using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class ExchangeRate_BelWeb
        {
            public string SourceCurrency { get; set; }
            public string TargetCurrency { get; set; }
            public double ExchangeRate { get; set; }
            public string Direction { get; set; }
        }

        public class ExchangeRate_nbrb
        {

            public string Cur_ID { get; set; }
            public string Date { get; set; }
            public string Cur_Abbreviation { get; set; }
            public string Cur_Scale { get; set; }
            public string Cur_Name { get; set; }
            public string Cur_OfficialRate { get; set; }
        }

        public class ExchangeRate_BB
        {

            public string kurs_date_time { get; set; }
            public string USDCARD_in { get; set; }
            public string USDCARD_out { get; set; }
            public string EURCARD_in { get; set; }
            public string EURCARD_out { get; set; }
            public string RUBCARD_in { get; set; }
            public string RUBCARD_out { get; set; }
            public string CNYCARD_in { get; set; }
            public string CNYCARD_out { get; set; }
        }
        private async void BelWebEx()
            {
                try
                {
                    string apiUrl = "https://kdoapi.bvb.by:8243/currency/v2/banks/BELBBY2X/services?type=currency_exchange";

                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync(apiUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            string content = await response.Content.ReadAsStringAsync();
                            var exchangeRates = JsonConvert.DeserializeObject<List<ExchangeRate_BelWeb>>(content);

                            var currentRate = exchangeRates.Find(rate =>
                             rate.SourceCurrency == "USD" &&
                             rate.TargetCurrency == "BYN");


                            if (currentRate != null)
                            {
                                BelWeb_USD_label.Text = $"Текущий курс {currentRate.SourceCurrency} к {currentRate.TargetCurrency}: {currentRate.ExchangeRate}";
                            }
                            else
                            {
                                BelWeb_USD_label.Text = "Курс не найден.";
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

        private async void nbrbEx()
        {
            nbrb_currency("https://api.nbrb.by/exrates/rates/431");
            nbrb_currency("https://api.nbrb.by/exrates/rates/451");
            nbrb_currency("https://api.nbrb.by/exrates/rates/456");
            nbrb_currency("https://api.nbrb.by/exrates/rates/462");


        }

        private async void nbrb_currency(string apiUrl)
        {
            try
            {

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        var exchangeRate = JsonConvert.DeserializeObject<ExchangeRate_nbrb>(content);

                        if (exchangeRate != null)
                        {
                            if (exchangeRate.Cur_Abbreviation == "USD")
                                nbrb_USD_label.Text = $"Текущий курс {exchangeRate.Cur_Abbreviation} к BYN: {exchangeRate.Cur_OfficialRate}";
                            if (exchangeRate.Cur_Abbreviation == "EUR")
                                nbrb_EUR_label.Text = $"Текущий курс {exchangeRate.Cur_Abbreviation} к BYN: {exchangeRate.Cur_OfficialRate}";
                            if (exchangeRate.Cur_Abbreviation == "RUB")
                                nbrb_RUB_label.Text = $"Текущий курс {exchangeRate.Cur_Abbreviation} к BYN: {exchangeRate.Cur_OfficialRate}";
                            if (exchangeRate.Cur_Abbreviation == "CNY")
                                nbrb_CNY_label.Text = $"Текущий курс {exchangeRate.Cur_Abbreviation} к BYN: {exchangeRate.Cur_OfficialRate}";


                        }
                        else
                        {
                            nbrb_USD_label.Text = "Курс не найден.";
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
        private async void BBEx()
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
                        var exchangeRates = JsonConvert.DeserializeObject<List<ExchangeRate_BB>>(content);

                        DateTime currentTime = DateTime.Now;
                        DateTime resetTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 0, 0, 0);
                        string formattedTime = resetTime.ToString("yyyy-MM-dd HH:mm:ss");
                        

                        var currentRate = exchangeRates.Find(rate =>
                                                    rate.kurs_date_time == formattedTime);


                        if (currentRate != null)
                        {
                            bb_USD_label.Text = $"Текущий курс USD к BYN: {currentRate.USDCARD_out}";
                            bb_EUR_label.Text = $"Текущий курс EUR к BYN: {currentRate.EURCARD_out}";
                            bb_RUB_label.Text = $"Текущий курс RUB к BYN: {currentRate.RUBCARD_out}";
                            bb_CNY_label.Text = $"Текущий курс CNY к BYN: {currentRate.CNYCARD_out}";

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
        private void Form1_Load(object sender, EventArgs e)
            {
            
            nbrbEx();
            BBEx();
            BelWebEx();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

