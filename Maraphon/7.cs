using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maraphon
{
    public partial class _7 : Form
    {
        int sum;
        string name;
        public _7(string name, int sum)
        {
            InitializeComponent();
            this.sum = sum;
            this.name = name;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label4.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут до старта марафона!";
        }

        private void _7_Load(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"\s");
            string[] result = regex.Split(name);
            label6.Text = result[0] + " " + result[1] + " из " + result[2];
            label7.Text = "$" + sum.ToString();
        }
    }
}
