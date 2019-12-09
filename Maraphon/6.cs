using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maraphon
{
    public partial class _6 : Form
    {
        public _6()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label4.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут до старта марафона!";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox7.Text);
            money += 10;
            textBox7.Text = money.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || maskedTextBox1.Text.Length < 16 || maskedTextBox3.Text.Length < 3)
            {
                MessageBox.Show("Поля заполнены неправильно");
            }

            _7 newForm = new _7(comboBox1.Text, Int32.Parse(textBox7.Text));
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox7.Text);
            if (money >= 10) money -= 10;
            textBox7.Text = money.ToString();
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            label17.Text = "$" + textBox7.Text;
        }

        private void _6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dEMODataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dEMODataSet1.DataTable1);
            // TODO: This line of code loads data into the 'dEMODataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.dEMODataSet.User);

        }
    }
}
