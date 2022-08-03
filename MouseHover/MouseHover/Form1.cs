using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseHover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomX = random.Next((this.Size.Width) - 100);
            int randomY = random.Next((this.Size.Height / 2) + 1, this.Size.Height - 100);
            button2.Location = new Point(randomX, randomY);
            Random rnd = new Random();
            int num1 = rnd.Next(0, 256);
            int num2 = rnd.Next(0, 256);
            int num3 = rnd.Next(0, 256);
            button2.Text = "Click me";
            button2.BackColor = Color.FromArgb(num1, num2, num3);
        }
    }
}
