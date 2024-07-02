using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;

namespace Practica
{
    internal class BelWeb
    {
        public string SourceCurrency { get; set; }
        public string TargetCurrency { get; set; }
        public double ExchangeRate { get; set; }
        public string Direction { get; set; }

        static public Label BelWeb_USD_label = new Label();
        static public Label BelWeb_EUR_label = new Label();
        static public Label BelWeb_RUB_label = new Label();
        static public Label BelWeb_CNY_label = new Label(); 

        public async void BelWebEx()
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
                        var exchangeRates = JsonConvert.DeserializeObject<List<BelWeb>>(content);

                        var currentRateUSD = exchangeRates.Find(rate =>
                         rate.SourceCurrency == "USD" &&
                         rate.TargetCurrency == "BYN");


                        if (currentRateUSD != null)
                        {
                            BelWeb_USD_label.Text = $"Текущий курс {currentRateUSD.SourceCurrency} к {currentRateUSD.TargetCurrency}: {Math.Round(currentRateUSD.ExchangeRate, 2)}";
                        }
                        else
                        {
                            BelWeb_USD_label.Text = "Курс не найден.";
                        }

                        var currentRateEUR = exchangeRates.Find(rate =>
                         rate.SourceCurrency == "EUR" &&
                         rate.TargetCurrency == "BYN");


                        if (currentRateEUR != null)
                        {
                            BelWeb_EUR_label.Text = $"Текущий курс {currentRateEUR.SourceCurrency} к {currentRateEUR.TargetCurrency}: {Math.Round(currentRateEUR.ExchangeRate,2)}";
                        }
                        else
                        {
                            BelWeb_EUR_label.Text = "Курс не найден.";
                        }

                        var currentRateRUB = exchangeRates.Find(rate =>
                             rate.SourceCurrency == "RUR" &&
                             rate.TargetCurrency == "BYN");


                        if (currentRateRUB != null)
                        {
                            BelWeb_RUB_label.Text = $"Текущий курс {currentRateRUB.SourceCurrency} к {currentRateRUB.TargetCurrency}: {Math.Round(currentRateRUB.ExchangeRate,2)}";
                        }
                        else
                        {
                            BelWeb_RUB_label.Text = "Курс не найден.";
                        }
                        var currentRateCNY = exchangeRates.Find(rate =>
                            rate.SourceCurrency == "CNY" &&
                            rate.TargetCurrency == "BYN");


                        if (currentRateCNY != null)
                        {
                            BelWeb_CNY_label.Text = $"Текущий курс {currentRateCNY.SourceCurrency} к {currentRateCNY.TargetCurrency}: {Math.Round(currentRateCNY.ExchangeRate,2) * 10}";
                        }
                        else
                        {
                            BelWeb_CNY_label.Text = "Курс не найден.";
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
