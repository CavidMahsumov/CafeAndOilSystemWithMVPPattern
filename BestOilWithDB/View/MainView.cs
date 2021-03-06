using BestOilWithDB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilWithDB.View
{
    public partial class MainView : Form, IMainView
    {
        public EventHandler<EventArgs> ComboboxIndexChange { get; set; }
        public EventHandler<EventArgs> CheckedChangedLiter { get; set; }
        public EventHandler<EventArgs> CheckedChangedAzn { get; set; }
        public EventHandler<EventArgs> CalculateButtonClicked { get; set; }
        public EventHandler<EventArgs> LoadButtonClicked { get; set; }
        public List<Petrol> Petrols
        {
            set
            {
                comboBox1.DataSource = null;
                comboBox1.DataSource = value;
            }
        }
        public List<Payment> Payments
        {
            set
            {
                listBox1.DataSource = null;
                listBox1.DataSource = value;
            }
        }
        
       
        public string PriceText { get => priceLbl.Text; set => priceLbl.Text = value; }
        public bool IsLitr { get => litrRadiobtn.Checked; set => litrRadiobtn.Checked = value; }
        public string LitrText { get => maskedTextBox1.Text; set => maskedTextBox1.Text = value; }
        public string MoneyText { get => maskedTextBox2.Text; set => maskedTextBox2.Text = value; }
        public string TotalText { get => totalLbl.Text; set => totalLbl.Text = value; }
        public bool LitrEnabled { get => maskedTextBox1.Enabled; set => maskedTextBox1.Enabled = value; }
        public bool PriceEnabled { get => maskedTextBox2.Enabled; set => maskedTextBox2.Enabled = value; }
        public EventHandler<EventArgs> HotDogCheckBoxClicked { get; set; }
        public EventHandler<EventArgs> HamburgerCheckBoxClicked { get; set; }
        public EventHandler<EventArgs> KartofFreeCheckBoxCliked { get; set; }
        public EventHandler<EventArgs> ColaCheckBoxCliked { get; set; }
        public string HotDogPrice { get => HotDogTextBox.Text; set => HotDogTextBox.Text = value; }
        public string HamburgerPrice { get => Hamburgertxtbox.Text; set => Hamburgertxtbox.Text = value; }
        public string KartofFreePrice { get => Freetxtbox.Text; set => Freetxtbox.Text = value; }
        public string ColaPrice { get => colatxtbox.Text; set => colatxtbox.Text = value; }
        string IMainView.HotDogCount { get => HotDogCount.Text; set => HotDogCount.Text = value; }
        public string HamburgerCount { get => HhamburgerCount.Text; set => HhamburgerCount.Text = value; }
        public string KartofFreeCount { get => Freecount.Text; set => Freecount.Text = value; }
        public string ColaCount { get => colocount.Text; set => colocount.Text = value; }
        string IMainView.CafeTotal { get => CafeTotalLabel.Text; set => CafeTotalLabel.Text = value; }
        public string TotalSystem { get => TotalLabelOilAndCafe.Text; set => TotalLabelOilAndCafe.Text = value; }
        public bool HotDogEnabled { get => HotDogCount.Enabled; set => HotDogCount.Enabled = value; }
        public bool ColaEnabled { get => colocount.Enabled; set => colocount.Enabled = value; }
        public bool HamburgerEnabled { get => HhamburgerCount.Enabled; set => HhamburgerCount.Enabled = value; }
        public bool KartofFreeEnabled { get => Freecount.Enabled; set => Freecount.Enabled = value; }

        public MainView()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxIndexChange.Invoke(sender, e);
        }
        private void litrRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedLiter.Invoke(sender, e);
        }
        private void aznRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedAzn.Invoke(sender, e);
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            CalculateButtonClicked.Invoke(sender, e);

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadButtonClicked.Invoke(sender, e);
        }

        private void HotDogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HotDogCheckBoxClicked.Invoke(sender, e);
        }

        private void Hamburgercheckboc_CheckedChanged(object sender, EventArgs e)
        {
            HamburgerCheckBoxClicked.Invoke(sender, e);
        }

        private void kartofFreecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            KartofFreeCheckBoxCliked.Invoke(sender, e);
        }

        private void CocoColacheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ColaCheckBoxCliked.Invoke(sender, e);
        }

        private void Hamburgertxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
