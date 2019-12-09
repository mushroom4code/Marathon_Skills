using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maraphon
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        public void setup(string bg, string s1, string s2) {
            try {
                pictureBox1.BackgroundImage = Image.FromFile(@"C: \Users\Max\Desktop\marathon - skills - 2016 - charity - data"+bg);
            }
            catch (Exception e)
            {
                pictureBox1.BackColor = Color.Gray;
            }
            label1.Text = s1;
            label2.Text = s2;
        }
    }
}
