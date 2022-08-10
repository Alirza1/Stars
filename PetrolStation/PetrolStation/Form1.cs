using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolStation
{
    public partial class Form1 : Form
    {
        double total;
        public Form1()
        {
            InitializeComponent();

            List<Petrol> petrols = new List<Petrol>
            {
                new Petrol{Name="AI-92",Price=1},
                new Petrol{Name="AI-95",Price=2},
                new Petrol{Name="Diesel",Price=0.80},

            };

            petrolCmbx.Items.AddRange(petrols.ToArray());
            petrolCmbx.DisplayMember = nameof(Name);
            //petrolCmbx.SelectedIndex = 0;



        }

        #region Useless
        private void o(object sender, EventArgs e)
        {

        }




        #endregion

        private void petrolCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            var result = petrolCmbx.SelectedItem as Petrol;
            if (result.Name == "AI-92")
                petrolPriceLbl.Text = result.Price.ToString();

            else if (result.Name == "AI-95")
                petrolPriceLbl.Text = result.Price.ToString();

            else if (result.Name == "Diesel")
                petrolPriceLbl.Text = result.Price.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            byLiterTxtb.Enabled = true;

        }
        private void byPriceTxtb_TextChanged(object sender, EventArgs e)
        {
            var result = petrolCmbx.SelectedItem as Petrol;
            if (byLiterTxtb.Text == string.Empty)
            {
                petrolPaymentlbl.Text = "00.00";
            }
            else
            {
                petrolPaymentlbl.Text = (int.Parse(byLiterTxtb.Text) * result.Price).ToString();
            }

        }


        private void byPriceRadio_CheckedChanged(object sender, EventArgs e)
        {
            byPriceTxtb.Enabled = true;
        }
        private void byPetrolTxtb_TextChanged(object sender, EventArgs e)
        {
            var result = petrolCmbx.SelectedItem as Petrol;
            if (byPriceTxtb.Text == string.Empty)
            {
                petrolPaymentlbl.Text = "00.00";
            }
            else
            {
                petrolPaymentlbl.Text = int.Parse(byPriceTxtb.Text).ToString();
            }
        }

        private List<CheckBox> GetCheckBox(object sender)
        {
            List<CheckBox> temp = new List<CheckBox>();

            foreach (var item in marketGb.Controls)
            {
                if (item is CheckBox ch)
                {
                    if (ch.Checked)
                    {
                        temp.Add(ch);
                    }
                }
            }

            return temp;
        }
        private void Help(string text, string textAmount)
        {
            if (textAmount != string.Empty)
            {
                var amount = double.Parse(text);
                total += amount * int.Parse(textAmount);
                miniMarketPriceLbl.Text = total.ToString();
            }
            else
            {
                miniMarketPriceLbl.Text = "00.00";
            }
        }

        private void hotdogTxtb_TextChanged(object sender, EventArgs e)
        {
            var ch = GetCheckBox(marketGb);
            if (ch != null)
            {
                foreach (var item in ch)
                {
                    if (item.Name == hotdogChkb.Name)
                    {
                        Help(hotdogPriceLbl.Text, hotdogTxtb.Text);
                    }
                }
            }
        }

        private void hamburgerTxtb_TextChanged(object sender, EventArgs e)
        {
            var ch = GetCheckBox(marketGb);
            if (ch != null)
            {
                foreach (var item in ch)
                {
                    if (item.Name == hamburgerChkb.Name)
                    {
                        Help(hamburgerPriceLbl.Text, hamburgerTxtb.Text);
                    }
                }
            }
        }

        private void frenchfTxtb_TextChanged(object sender, EventArgs e)
        {
            var ch = GetCheckBox(marketGb);
            if (ch != null)
            {
                foreach (var item in ch)
                {
                    if (item.Name == frenchfChkb.Name)
                    {
                        Help(frenchfPriceLbl.Text, frenchfTxtb.Text);
                    }
                }
            }
        }

        private void cocacolaTxtb_TextChanged(object sender, EventArgs e)
        {
            var ch = GetCheckBox(marketGb);
            if (ch != null)
            {
                foreach (var item in ch)
                {
                    if (item.Name == cocacolaChkb.Name)
                    {
                        Help(cocacolaPriceLbl.Text, cocacolaTxtb.Text);
                    }
                }
            }
        }

        private void sirabTxtb_TextChanged(object sender, EventArgs e)
        {
            var ch = GetCheckBox(marketGb);
            if (ch != null)
            {
                foreach (var item in ch)
                {
                    if (item.Name == sirabChkb.Name)
                    {
                        Help(sirabPriceLbl.Text, sirabTxtb.Text);
                    }
                }
            }

        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            finalPaymentLbl.Text = (double.Parse(petrolPaymentlbl.Text) + double.Parse(miniMarketPriceLbl.Text)).ToString();

        }
    }
}
