using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anket
{
    public partial class Form1 : Form
    {

        public static void JSonSerializer(User user)
        {
            var serializer = new JsonSerializer();
            string fileName = user.Name + ".json";

            using (var sw = new StreamWriter(fileName))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, user);
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            User user = new User(nameTxtb.Text, surnameTxtb.Text, emailTxtb.Text, numberMtxtb.Text);
            JSonSerializer(user);
            nameTxtb.Text = string.Empty;
            surnameTxtb.Text = string.Empty;
            emailTxtb.Text = string.Empty;
            numberMtxtb.Text = string.Empty;
        }
    }
}
