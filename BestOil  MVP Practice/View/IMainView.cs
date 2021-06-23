using BestOil__MVP_Practice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil__MVP_Practice.View
{
    public interface IMainView
    {
        EventHandler<EventArgs> BuyButtunClicked { get; set; }
        string Cashtext { get; set; }
        string Litertext { get; set; }
        string Pricetext { get; set; }
        string Amounttext { get; set; }
        bool isLiter { get; set; }

        List<GasOil> GasOils { set; }

    }
}
