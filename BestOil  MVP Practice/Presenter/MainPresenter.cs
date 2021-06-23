using BestOil__MVP_Practice.Data;
using BestOil__MVP_Practice.Model;
using BestOil__MVP_Practice.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil__MVP_Practice.Presenter
{
    public class MainPresenter
    {
        private readonly GasOilContext _db;
        private IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
            _view.BuyButtunClicked += ViewBuyButtonClicked;
            _db = new GasOilContext();
            //_db.GasOils.Add(new GasOil { Name = "AI-92", Price = 1.00 });
            //_db.GasOils.Add(new GasOil { Name = "AI-95", Price = 1.50 });
            //_db.GasOils.Add(new GasOil { Name = "AI-98", Price = 2.25 });
            _db.SaveChanges();

            var list = _db.GasOils.ToList();
            _view.GasOils = list;
        }

        private void ViewBuyButtonClicked(object sender, EventArgs e)
        {
            var price = double.Parse(_view.Cashtext.ToString());
            _view.Pricetext = price.ToString();

            _db.SaveChanges();
        }
    }
}
