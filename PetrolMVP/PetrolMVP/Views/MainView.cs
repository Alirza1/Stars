using PetrolMVP.Models;
using PetrolMVP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolMVP
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }
        public List<Petrol> petrols 
        { 
            set 
            {
                comboBox1.DataSource = null;
                comboBox1.DataSource = value;
            } 
        }

        public EventHandler<EventArgs> CbSelectedItem { get; set; }
        public EventHandler<EventArgs> byPetrolCheckCh { get; set; }
        public EventHandler<EventArgs> byPriceCheckCh { get; set; }
        public EventHandler<EventArgs> byPetrolTextCh { get; set; }
        public EventHandler<EventArgs> byPriceTextCh { get; set; }
        public ComboBox comboBox { get => comboBox1; set => comboBox=value; }
        public Label petrolPrice { get => petrolPriceLbl; set => petrolPriceLbl=value; }
        public Label total { get => paymentLbl; set => paymentLbl=value; }
        RadioButton IMainView.byPrice { get => byPrice; set => byPrice=value; }
        public RadioButton byPetrol { get => byLiter; set => byLiter=value; }
        public TextBox byPricetx { get => byPriceTxtb; set => byPriceTxtb=value; }
        public TextBox byPetroltx { get => byLiterTxtb; set => byLiterTxtb=value; }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbSelectedItem.Invoke(sender, e);
        }

        private void byLiter_CheckedChanged(object sender, EventArgs e)
        {
            byPetrolCheckCh.Invoke(sender, e);
        }

        private void byPrice_CheckedChanged(object sender, EventArgs e)
        {
            byPriceCheckCh.Invoke(sender, e);
        }

        private void byLiterTxtb_TextChanged(object sender, EventArgs e)
        {
            byPetrolTextCh.Invoke(sender, e);
        }

        private void byPriceTxtb_TextChanged(object sender, EventArgs e)
        {
            byPriceTextCh.Invoke(sender, e);
        }


    }
}
