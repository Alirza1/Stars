using PetrolMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolMVP.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> CbSelectedItem { get; set; }
        EventHandler<EventArgs> byPetrolCheckCh { get; set; }
        EventHandler<EventArgs> byPriceCheckCh { get; set; }
        EventHandler<EventArgs> byPetrolTextCh { get; set; }
        EventHandler<EventArgs> byPriceTextCh { get; set; }
        List<Petrol> petrols { set; }
        ComboBox comboBox { set; get; }
        Label petrolPrice { set; get; }
        Label total { set; get; }
        RadioButton byPrice { set; get; }
        RadioButton byPetrol { set; get; }
        TextBox byPricetx { set; get; }
        TextBox byPetroltx { set; get; }

    }
}
