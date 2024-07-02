using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            Nbrb.nbrb_USD_label = nbrb_USD_label;
            Nbrb.nbrb_EUR_label = nbrb_EUR_label;
            Nbrb.nbrb_RUB_label = nbrb_RUB_label;
            Nbrb.nbrb_CNY_label = nbrb_CNY_label;
            BelWeb.BelWeb_USD_label = BelWeb_USD_label;
            BelWeb.BelWeb_EUR_label = BelWeb_EUR_label;
            BelWeb.BelWeb_RUB_label = BelWeb_RUB_label;
            BelWeb.BelWeb_CNY_label = BelWeb_CNY_label;
            BB.bb_USD_label = bb_USD_label;
            BB.bb_EUR_label = bb_EUR_label;
            BB.bb_RUB_label = bb_RUB_label;
            BB.bb_CNY_label = bb_CNY_label;
            cordinates.gMapControl1 = gMapControl1;
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            Nbrb nbrb = new Nbrb();
            nbrb.nbrbEx();
            BB bb = new BB();
            bb.BBEx();
            BelWeb belWeb = new BelWeb();
            belWeb.BelWebEx();

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void map_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button_map_Click(object sender, EventArgs e)
        {
            cordinates cordinates = new cordinates();
            cordinates.loadMap();

        }

        private void button_kyrs_Click(object sender, EventArgs e)
        {
            gMapControl1.Visible = false;
        }
    }
 }

