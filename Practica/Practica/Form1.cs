using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
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
                                BelWeb_label.Text = $"Текущий курс {currentRate.SourceCurrency} к {currentRate.TargetCurrency} ({currentRate.Direction}): {currentRate.ExchangeRate}";
                            }
                            else
                            {
                                BelWeb_label.Text = "Курс не найден.";
                            }
                            // Обработка данных из ответа (в формате JSON)
                            // Например, десериализация и отображение на форме
                            // Например:
                            // dynamic data = JsonConvert.DeserializeObject(content);
                            // BelWeb_label.Text = data.ToString();
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
            try
            {
                string apiUrl = "https://api.nbrb.by/exrates/rates/431";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        var exchangeRate = JsonConvert.DeserializeObject<ExchangeRate_nbrb>(content);

                        if (exchangeRate != null)
                        {
                            nbrb_label.Text = $"Текущий курс {exchangeRate.Cur_Abbreviation} к BYN: {exchangeRate.Cur_OfficialRate}";
                            // Обновление интерфейса (например, this.Invalidate())
                        }
                        else
                        {
                            nbrb_label.Text = "Курс не найден.";
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
                BelWebEx();
                nbrbEx();
            }
        }
 }

