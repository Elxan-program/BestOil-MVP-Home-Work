using BestOil__MVP_Practice.Model;
using BestOil__MVP_Practice.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil__MVP_Practice
{
    public partial class MainView : Form , IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }
        public EventHandler<EventArgs> BuyButtunClicked { get; set; }
        public string Cashtext { get => Cashtxtbox.Text; set => Cashtxtbox.Text = value; }
        public string Litertext { get => Litertxtbox.Text; set => Litertxtbox.Text = value; }
        public string Pricetext { get => Price.Text; set => Price.Text = value; }
        public string Amounttext { get => Amount.Text; set => Amount.Text = value; }
        public bool isLiter { get => Liter_radio_btn.Checked; set => Liter_radio_btn.Checked = value; }
        public List<GasOil> GasOils { set {
                GasComboBox.DataSource = null;
                GasComboBox.DataSource = value;
            } }

        private void Buy_Btn_Click(object sender, EventArgs e)
        {
            BuyButtunClicked.Invoke(sender, e);
        }

        //private void MainView_Load(object sender, EventArgs e)
        //{
        //    GasComboBox.DisplayMember = "Name";
        //    List<GasOil> gasOils = new List<GasOil>
        //{
        //    new GasOil
        //    {
        //        Name = "AI-92",
        //        Price = 1.00
        //    },
        //    new GasOil
        //    {
        //        Name = "AI-95",
        //        Price = 1.50
        //    },
        //    new GasOil
        //    {
        //        Name = "AI-98",
        //        Price = 2.25
        //    }
        //};

        //    GasComboBox.DataSource = gasOils;
        //}

        private void GasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = GasComboBox.SelectedItem as GasOil;
            Amount.Text = result.Price.ToString();
        }

        private void Litertxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var petrol = GasComboBox.SelectedItem as GasOil;
                var litertext = double.Parse(Litertxtbox.Text) * petrol.Price;
                Cashtxtbox.Text = litertext.ToString();

            }
            catch (Exception){}
        }

        private void Cashtxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var petrol = GasComboBox.SelectedItem as GasOil;
                var cashtext = double.Parse(Cashtxtbox.Text) / petrol.Price;
                Litertxtbox.Text = cashtext.ToString();
            }
            catch (Exception){}
        }

        private void Cash_radio_btn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
