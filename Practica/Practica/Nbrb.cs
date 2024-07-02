using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static Practica.Form1;
using System.Windows.Forms;

namespace Practica
{
    public class Nbrb
    {
        public string Cur_ID { get; set; }
        public string Date { get; set; }
        public string Cur_Abbreviation { get; set; }
        public string Cur_Scale { get; set; }
        public string Cur_Name { get; set; }
        public double Cur_OfficialRate { get; set; }
        static public Label nbrb_USD_label = new Label();
        static public Label nbrb_EUR_label = new Label();
        static public Label nbrb_RUB_label = new Label();
        static public Label nbrb_CNY_label = new Label();

        public async void nbrbEx()
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
                            var exchangeRate = JsonConvert.DeserializeObject<Nbrb>(content);

                            if (exchangeRate != null)
                            {
                                if (exchangeRate.Cur_Abbreviation == "USD")
                                    nbrb_USD_label.Text = $"Текущий курс {exchangeRate.Cur_Abbreviation} к BYN: {Math.Round(exchangeRate.Cur_OfficialRate, 2)}";
                                if (exchangeRate.Cur_Abbreviation == "EUR")
                                    nbrb_EUR_label.Text = $"Текущий курс {exchangeRate.Cur_Abbreviation} к BYN: {Math.Round(exchangeRate.Cur_OfficialRate, 2)}";
                                if (exchangeRate.Cur_Abbreviation == "RUB")
                                    nbrb_RUB_label.Text = $"Текущий курс {exchangeRate.Cur_Abbreviation} к BYN: {Math.Round(exchangeRate.Cur_OfficialRate, 2)}";
                                if (exchangeRate.Cur_Abbreviation == "CNY")
                                    nbrb_CNY_label.Text = $"Текущий курс {exchangeRate.Cur_Abbreviation} к BYN: {Math.Round(exchangeRate.Cur_OfficialRate, 2)}";


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


        }
 }

   

   




