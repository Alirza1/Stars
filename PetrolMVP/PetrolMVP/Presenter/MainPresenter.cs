using PetrolMVP.Models;
using PetrolMVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolMVP.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView _view;

        List<Petrol> petrols = new List<Petrol>
        {
            new Petrol
            { 
                Name="AI-92",
                Price=1.0
            },
            new Petrol
            {
                Name="AI-95",
                Price=2.0
            },
            new Petrol
            {
                Name="Diesel",
                Price=0.80
            }
        };



        public MainPresenter(IMainView view)
        {
            _view = view;
            _view.comboBox.Items.AddRange(petrols.ToArray());

            _view.CbSelectedItem += ViewCbSelectedIndexChanged;
            _view.byPetrolTextCh += ViewByPetrolTextCh;
            _view.byPriceTextCh += ViewByPriceTextCh;
            _view.byPriceCheckCh += ViewByPriceCheckCh;
            _view.byPetrolCheckCh += ViewByPetrolCheckCh;
        }

        public void ViewCbSelectedIndexChanged(object sender,EventArgs e)
        {
            var result = _view.comboBox.SelectedItem as Petrol;
            if (result.Name == "AI-92")
                _view.total.Text = result.Price.ToString();

            else if (result.Name == "AI-95")
                _view.total.Text = result.Price.ToString();

            else if (result.Name == "Diesel")
                _view.total.Text = result.Price.ToString();
        }

        public void ViewByPriceCheckCh(object sender, EventArgs e)
        {
            _view.byPricetx.Enabled = true;
        }

        public void ViewByPetrolCheckCh(object sender, EventArgs e)
        {
            _view.byPetroltx.Enabled = true;
        }

        public void ViewByPetrolTextCh(object sender, EventArgs e)
        {
            var result = _view.comboBox.SelectedItem as Petrol;
            if (_view.byPetroltx.Text == string.Empty)
            {
                _view.total.Text = "00.00";
            }
            else
            {
                _view.total.Text = (int.Parse(_view.byPetroltx.Text) * result.Price).ToString();
            }
        }

        public void ViewByPriceTextCh(object sender, EventArgs e)
        {
            var result = _view.comboBox.SelectedItem as Petrol;
            if (_view.byPricetx.Text == string.Empty)
            {
                _view.total.Text = "00.00";
            }
            else
            {
                _view.total.Text = int.Parse(_view.byPricetx.Text).ToString();
            }
        }
    }
}
