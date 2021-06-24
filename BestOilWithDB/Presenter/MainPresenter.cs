using BestOilWithDB.Data;
using BestOilWithDB.Model;
using BestOilWithDB.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilWithDB.Presenter
{
    public class MainPresenter
    {
        private readonly PetrolContext _db;
        private IMainView _view;
        public Double TotalResultOilSystem { get; set; }
        public MainPresenter(IMainView view)
        {
            _view = view;

            _db = new PetrolContext();
            _view.CafeTotal = String.Empty;

            //_db.Petrols.Add(new Petrol { Name = "AI95", Price = 1.4 });
            //_db.Petrols.Add(new Petrol { Name = "AI92", Price = 1 });
            //_db.Petrols.Add(new Petrol { Name = "DIZEL", Price = 0.8 });
            //_db.Cafes.Add(new Cafe { Name = "HotDog", Price = 2.10 });
            //_db.Cafes.Add(new Cafe { Name = "Cola", Price = 1 });
            //_db.Cafes.Add(new Cafe { Name = "KartofFree", Price = 3.20 });
            //_db.Cafes.Add(new Cafe { Name = "Hamburger", Price = 2.30 });


            _view.ComboboxIndexChange += ComboboxIndexCanged;
            _view.CheckedChangedLiter += LiterChechkedChanged;
            _view.CheckedChangedAzn += AznChechkedChanged;
            _view.CalculateButtonClicked += CalculateButtonClicked;
            _view.LoadButtonClicked += LoadButtonClicked;
            _view.HotDogCheckBoxClicked += HotDogCheckBoxCliked;
            _view.HamburgerCheckBoxClicked += HamburgerCheckBoxCliked;
            _view.KartofFreeCheckBoxCliked += KartofFreeCheckBoxCliked;
            _view.ColaCheckBoxCliked += ColaCheckBoxCliked;

            _db.SaveChanges();
            //_dbCafe.SaveChanges();
            var data = _db.Cafes.ToArray();
            var HotdogPrice = data[0]?.Price;
            var HamburgerPRice = data[3]?.Price;
            var Free = data[2]?.Price;
            var Cola = data[1]?.Price;

            _view.HotDogPrice = HotdogPrice.ToString();
            _view.HamburgerPrice = HamburgerPRice.ToString();
            _view.KartofFreePrice = Free.ToString();
            _view.ColaPrice = Cola.ToString();

            var list = _db.Petrols.ToList();
            //var list1 = _db.Cafes.ToList();
            //var list1 = _dbCafe.Cafes.ToList();
            _view.Petrols = list;

            //_view.Cafes = list1;

        }
        public string NameOfOil { get; set; }
        public double Result { get; set; }
        public string name { get; set; }
        public void ComboboxIndexCanged(object sender, EventArgs e)
        {
            var item = (sender as ComboBox).SelectedItem;
            var petrol = item as Petrol;
            NameOfOil = petrol.Name;
            _view.PriceText = petrol.Price.ToString();
        }
        public void HotDogCheckBoxCliked(object sender, EventArgs e)
        {
            var item = sender as CheckBox;
            if (item.Checked)
            {
                _view.HotDogEnabled = true;
            }
            else
            {
                _view.HotDogEnabled = false;
            }
            _view.CafeTotal = string.Empty;




        }
        public void HamburgerCheckBoxCliked(object sender, EventArgs e)
        {
            var item = sender as CheckBox;
            if (item.Checked)
            {
                _view.HamburgerEnabled = true;
            }
            else
            {
                _view.HamburgerEnabled = false;
            }

        }
        public void KartofFreeCheckBoxCliked(object sender, EventArgs e)
        {
            var item = sender as CheckBox;
            if (item.Checked)
            {
                _view.KartofFreeEnabled = true;
            }
            else
            {
                _view.KartofFreeEnabled = false;
            }

        }
        public void ColaCheckBoxCliked(object sender, EventArgs e)
        {
            var item = sender as CheckBox;
            if (item.Checked)
            {
                _view.ColaEnabled = true;
            }
            else
            {
                _view.ColaEnabled = false;
            }

        }
        public void LiterChechkedChanged(object sender, EventArgs e)
        {

            var item = sender as RadioButton;
            if (item.Checked)
            {
                _view.LitrEnabled = true;
            }
            else
            {
                _view.LitrEnabled = false;
            }
        }

        public void AznChechkedChanged(object sender, EventArgs e)
        {
            var item = sender as RadioButton;
            if (item.Checked)
            {
                _view.PriceEnabled = true;
            }
            else
            {
                _view.PriceEnabled = false;
            }
        }

        public void CalculateButtonClicked(object sender, EventArgs e)
        {
            if (_view.LitrEnabled == true)
            {
                var money = double.Parse(_view.LitrText) * double.Parse(_view.PriceText);
                _view.TotalText = money.ToString();
            }
            else if (_view.PriceEnabled == true)
            {
                var money = double.Parse(_view.MoneyText) / double.Parse(_view.PriceText);
                _view.LitrText = String.Empty;
                var moneyFull = (int)money;
                _view.LitrText = moneyFull.ToString();
                _view.TotalText = _view.MoneyText;
            }

            if (_view.HotDogEnabled == true)
            {

                _view.CafeTotal = string.Empty;

                Double result = double.Parse(_view.HotDogPrice) * double.Parse(_view.HotDogCount);
                Result += result;

                _view.CafeTotal += Result.ToString();
            }
            if (_view.ColaEnabled == true)
            {
                _view.CafeTotal = string.Empty;

                Double result = double.Parse(_view.ColaPrice) * double.Parse(_view.ColaCount);
                Result += result;

                _view.CafeTotal += Result.ToString();
            }
            if (_view.HamburgerEnabled == true)
            {
                _view.CafeTotal = string.Empty;

                Double result = double.Parse(_view.HamburgerPrice) * double.Parse(_view.HamburgerCount);
                Result += result;

                _view.CafeTotal += Result.ToString();
            }
            if (_view.KartofFreeEnabled == true)
            {
                _view.CafeTotal = string.Empty;
                Double result = double.Parse(_view.KartofFreePrice) * double.Parse(_view.KartofFreeCount);
                Result += result;

                _view.CafeTotal += Result.ToString();

            }

            if (_view.LitrEnabled == true || _view.PriceEnabled == true)
            {
                Payment payment = new Payment
                {
                    Liter = int.Parse(_view.LitrText),
                    Oil = NameOfOil,
                    TotalPayment = double.Parse(_view.TotalText)
                };
                
               
                _db.Payments.Add(payment);
                _db.SaveChanges();
            }


            _view.HotDogEnabled = false;
            _view.ColaEnabled = false;
            _view.HamburgerEnabled = false;
            _view.KartofFreeEnabled = false;
            TotalResultOilSystem = double.Parse(_view.CafeTotal)+double.Parse(_view.TotalText);
            _view.TotalSystem = TotalResultOilSystem.ToString();
            _view.LitrEnabled = false;
            _view.PriceEnabled = false;



        }

        public void LoadButtonClicked(object sender, EventArgs e)
        {
            var list = _db.Payments;
            _view.Payments = list.ToList();
        }
    }
}
