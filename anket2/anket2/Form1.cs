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

namespace anket2
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
            listBox.DisplayMember = nameof(User.Name);
        }

        #region useless

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void anket_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        public void JSonSerializer(List<User> users)
        {
            var serializer = new JsonSerializer();
            string fileName = filenameTxtb.Text + ".json";

            using (var sw = new StreamWriter(fileName))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, users);
                }
            }
        }

        public void JSonDeserialize()
        {
            var serializer = new JsonSerializer();
            string fileName = filenameTxtb.Text + ".json";
            using (var sr = new StreamReader(fileName))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    users = serializer.Deserialize<List<User>>(jr);
                }
            }
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            User user = new User(nameTxtb.Text, surnameTxtb.Text, emailTxtb.Text, numberMtxtb.Text);
            users.Add(user);
            nameTxtb.Text = string.Empty;
            surnameTxtb.Text = string.Empty;
            emailTxtb.Text = string.Empty;
            numberMtxtb.Text = string.Empty;
            listBox.Items.Add(user);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            JSonSerializer(users);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            JSonDeserialize();
        }
    }
}
