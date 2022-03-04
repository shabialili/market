using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Database database = new Database();
        List<Food> temp = new List<Food>();
        Stock stock = new Stock()
        {
            albeni = 100,
            bounty = 100,
            snickers = 100,
            cola = 100,
            fanta = 100,
            icetea = 100,
            mars = 100,
            pepsi = 100,
            tutku = 100
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            uc_cola.lbl_name.Text = "Cola";
            uc_albeni.lbl_name.Text = "Albeni";
            uc_bounty.lbl_name.Text = "Bounty";
            uc_fanta.lbl_name.Text = "Fanta";
            uc_icetea.lbl_name.Text = "Ice Tea";
            uc_pepsi.lbl_name.Text = "Pepsi";
            uc_snickers.lbl_name.Text = "Snickers";
            uc_tutku.lbl_name.Text = "Tutku";
            uc_mars.lbl_name.Text = "Mars";

            uc_cola.lbl_q.Text = "1.00";
            uc_fanta.lbl_q.Text = "1.00";
            uc_icetea.lbl_q.Text = "1.00";
            uc_pepsi.lbl_q.Text = "1.00";
            uc_snickers.lbl_q.Text = "1.00";
            uc_mars.lbl_q.Text = "1.00";
            uc_tutku.lbl_q.Text = "1.00";
            uc_albeni.lbl_q.Text = "1.00";
            uc_bounty.lbl_q.Text = "1.00";
            if (File.Exists("users.json"))
            {
                var jsonStr = File.ReadAllText("users.json");
                database = JsonConvert.DeserializeObject<Database>(jsonStr);
            }
            if (File.Exists("market.json"))
            {
                var jsonStr = File.ReadAllText("market.json");
                stock = JsonConvert.DeserializeObject<Stock>(jsonStr);
                uc_cola.lbl_say.Text = stock.cola.ToString();
                uc_mars.lbl_say.Text = stock.mars.ToString();
                uc_bounty.lbl_say.Text = stock.bounty.ToString();
                uc_albeni.lbl_say.Text = stock.albeni.ToString();
                uc_snickers.lbl_say.Text = stock.snickers.ToString();
                uc_tutku.lbl_say.Text = stock.tutku.ToString();
                uc_pepsi.lbl_say.Text = stock.pepsi.ToString();
                uc_fanta.lbl_say.Text = stock.fanta.ToString();
                uc_icetea.lbl_say.Text = stock.icetea.ToString();
            }
            else
            {

                uc_cola.lbl_say.Text = stock.cola.ToString();
                uc_mars.lbl_say.Text = stock.mars.ToString();
                uc_bounty.lbl_say.Text = stock.bounty.ToString();
                uc_albeni.lbl_say.Text = stock.albeni.ToString();
                uc_snickers.lbl_say.Text = stock.snickers.ToString();
                uc_tutku.lbl_say.Text = stock.tutku.ToString();
                uc_pepsi.lbl_say.Text = stock.pepsi.ToString();
                uc_fanta.lbl_say.Text = stock.fanta.ToString();
                uc_icetea.lbl_say.Text = stock.icetea.ToString();

            }
        }

        private void btn_pul_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "btn_10q")
            {
                lbl_money.Text = (double.Parse(lbl_money.Text) + 0.1).ToString();
            }
            else if ((sender as Button).Name == "btn_20q")
            {
                lbl_money.Text = (double.Parse(lbl_money.Text) + 0.2).ToString();
            }
            else if ((sender as Button).Name == "btn_50q")
            {
                lbl_money.Text = (double.Parse(lbl_money.Text) + 0.5).ToString();
            }
            else if ((sender as Button).Name == "btn_1m")
            {
                lbl_money.Text = (double.Parse(lbl_money.Text) + 1.0).ToString();
            }
            else if ((sender as Button).Name == "btn_5m")
            {
                lbl_money.Text = (double.Parse(lbl_money.Text) + 5.0).ToString();
            }
            else if ((sender as Button).Name == "btn_10m")
            {
                lbl_money.Text = (double.Parse(lbl_money.Text) + 10.0).ToString();
            }

        }

        private void btn_almaq_Click(object sender, EventArgs e)
        {
            database.users.Add(new User()
            {
                foods = temp,
                odenilmis_mebleg = double.Parse(lbl_money.Text),
                qaliq_mebleg = double.Parse(lbl_qaliq.Text),
                yekun_mebleg = double.Parse(lbl_total.Text),
            });
            var str = JsonConvert.SerializeObject(stock, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("market.json", str);
            var str1 = JsonConvert.SerializeObject(database, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("users.json", str1);
            lbl_money.Text = "0";
            lbl_qaliq.Text = "0";
            lbl_total.Text = "0";

            temp = new List<Food>();
        }
        double count = 0;
        private void seç_Click(object sender, EventArgs e)
        {
            if (sender == button_cola)
            {
                if (double.Parse(lbl_money.Text) >= 1)
                {
                    temp.Add(new Food() { Name = "Coca Cola", Price = 1 });
                    count += 1;
                    lbl_total.Text = count.ToString();
                    lbl_qaliq.Text = (double.Parse(lbl_money.Text) - count).ToString();
                    stock.cola--;
                   
                }
            }
            else if (sender == button_fanta)
            {
                if (double.Parse(lbl_money.Text) >= 1)
                {
                    temp.Add(new Food() { Name = "Fanta", Price = 1 });
                    count += 1;
                    lbl_total.Text = count.ToString();
                    lbl_qaliq.Text = (double.Parse(lbl_money.Text) - count).ToString();
                    stock.fanta--;
                    
                }
            }
            else if (sender == button_pepsi)
            {
                if (double.Parse(lbl_money.Text) >= 1)
                {
                    temp.Add(new Food() { Name = "Pepsi", Price = 1 });
                    count += 1;
                    lbl_total.Text = count.ToString();
                    lbl_qaliq.Text = (double.Parse(lbl_money.Text) - count).ToString();
                    stock.pepsi--;
                    
                    
                }
            }
            else if (sender == button_icetea)
            {
                if (double.Parse(lbl_money.Text) >= 1)
                {
                    temp.Add(new Food() { Name = "Ice Tea", Price = 1});
                    count += 1;
                    lbl_total.Text = count.ToString();
                    lbl_qaliq.Text = (double.Parse(lbl_money.Text) - count).ToString();
                    stock.icetea--;
                   
                }

            }
            else if (sender == button_bounty)
            {
                if (double.Parse(lbl_money.Text) >= 1)
                {
                    temp.Add(new Food() { Name = "Bounty", Price = 1 });
                    count += 1;
                    lbl_total.Text = count.ToString();
                    lbl_qaliq.Text = (double.Parse(lbl_money.Text) - count).ToString();
                    stock.bounty--;
                  
                }

            }
            else if (sender == button_mars)
            {
                if (double.Parse(lbl_money.Text) >= 1)
                {
                    temp.Add(new Food() { Name = "Mars",Price = 1  });
                    count += 1;
                    lbl_total.Text = count.ToString();
                    lbl_qaliq.Text = (double.Parse(lbl_money.Text) - count).ToString();
                    stock.mars--;
                    
                }

            }
            else if (sender == button_snickers)
            {
                if (double.Parse(lbl_money.Text) >= 1)
                {
                    temp.Add(new Food() { Name = "Snicker", Price = 1});
                    count += 1;
                    lbl_total.Text = count.ToString();
                    lbl_qaliq.Text = (double.Parse(lbl_money.Text) - count).ToString();
                    stock.snickers--;
                   
                }

            }
            else if (sender == button_tutku)
            {
                if (double.Parse(lbl_money.Text) >= 1)
                {
                    temp.Add(new Food() { Name = "Tutku", Price = 1 });
                    count += 1;
                    lbl_total.Text = count.ToString();
                    lbl_qaliq.Text = (double.Parse(lbl_money.Text) - count).ToString();
                    stock.tutku--;
                   
                }

            }
            else if (sender == button_albeni)
            {
                if (double.Parse(lbl_money.Text) >= 1)
                {
                    temp.Add(new Food() { Name = "Albeni", Price = 1  });
                    count += 1;
                    lbl_total.Text = count.ToString();
                    lbl_qaliq.Text = (double.Parse(lbl_money.Text) - count).ToString();
                    stock.albeni--;
                   
                }

            }
        }
    }
}


