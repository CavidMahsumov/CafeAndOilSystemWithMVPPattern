using BestOilWithDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilWithDB.View
{
    public interface IMainView
    {
        EventHandler<EventArgs> ComboboxIndexChange { get; set; }
        EventHandler<EventArgs> CheckedChangedLiter { get; set; }
        EventHandler<EventArgs> CheckedChangedAzn { get; set; }
        EventHandler<EventArgs> CalculateButtonClicked { get; set; }
        EventHandler<EventArgs> LoadButtonClicked { get; set; }
        EventHandler<EventArgs> HotDogCheckBoxClicked { get; set; }
        EventHandler<EventArgs> HamburgerCheckBoxClicked { get; set; }
        EventHandler<EventArgs> KartofFreeCheckBoxCliked { get; set; }
        EventHandler<EventArgs> ColaCheckBoxCliked { get; set; }


        List<Petrol> Petrols { set; }
        List<Payment> Payments { set; }
        string PriceText { get; set; }
        bool IsLitr { get; set; }
        string LitrText { get; set; }
        string MoneyText { get; set; }
        string TotalText { get; set; }
        string HotDogPrice { get; set; }
        string HamburgerPrice { get; set; }
        string KartofFreePrice { get; set; }
        string ColaPrice { get; set; }
        string HotDogCount { get; set; }
        string HamburgerCount { get; set; }
        string KartofFreeCount { get; set; }
        string ColaCount { get; set; }
        string CafeTotal { get; set; }
        string TotalSystem { get; set; }
        bool LitrEnabled { get; set; }
        bool PriceEnabled { get; set; }
        bool HotDogEnabled { get; set; }
        bool ColaEnabled { get; set; }
        bool HamburgerEnabled { get; set; }
        bool KartofFreeEnabled { get; set; }
    }
}
