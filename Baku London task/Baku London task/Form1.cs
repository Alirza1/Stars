using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baku_London_task
{
    public partial class Form1 : Form
    {

        // Define local time in local time zone

        // Convert local time to offset 0 and assign to otherTime
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Tick += Timer_Tick;
            this.BackgroundImage = Properties.Resources.download;
        }

        private void Timer_Tick_London(object sender, EventArgs e)
        {
            label1.Text = "London hour";
        }

        private void London_Click(object sender, EventArgs e)
        {
            timer.Tick += Timer_Tick_London;
            this.BackgroundImage = Properties.Resources.topic_london_gettyimages_760251843_promo;

        }
    }
}
