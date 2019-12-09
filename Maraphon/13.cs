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
    public partial class _13 : Form
    {
        public _13()
        {
            InitializeComponent();
        }
        UserControl1[] ctl;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label4.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут до старта марафона!";
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _13_Load(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            List<string> description = new List<string>();
            List<string> logo = new List<string>();

            /* myCon = new SqlConnection(connectionString); 
 myCon.Open(); 
 string sql = "Select CharityName, CharityDescription, CharityLogo FROM Charity"; 
 SqlCommand command = new SqlCommand(sql, myCon); 
 
 try 
 { 
 SqlDataReader dr = command.ExecuteReader(); 
 int i = 0; 
 
 while (dr.Read()) { 
 names.Add(dr["CharityName"].ToString()); 
 description.Add( dr["CharityDescription"].ToString()); 
 logo.Add(dr["CharityLogo"].ToString()); 
 i++; 
 } 
 } 
 catch (Exception ex) { 
 MessageBox.Show(ex.Message); 
 } 
 */

            List<string> id = new List<string>();
            DEMODataSet.CharityDataTable charities = new DEMODataSet.CharityDataTable();
            DEMODataSetTableAdapters.CharityTableAdapter charityTableAdapter = new DEMODataSetTableAdapters.CharityTableAdapter();
            charityTableAdapter.Fill(charities);
            int k = 0;
            try
            {
                foreach (DataRow dr in charities.Rows)
                {
                    id.Add(dr["CharityId"].ToString());
                    names.Add(dr["CharityName"].ToString());
                    description.Add(dr["CharityDescription"].ToString());
                    logo.Add(dr["CharityLogo"].ToString());
                    k++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ctl = new UserControl1[names.Count];

            for (int i = 0; i < names.Count; i++)
            {
                ctl[i] = new UserControl1();
                ctl[i].setup(logo[i].ToString(), names[i].ToString(), description[i].ToString());
                if (i == 0)
                {
                    ctl[i].Top = 300;
                }
                else
                {
                    ctl[i].Top = ctl[i - 1].Top + ctl[i].Height;
                }
                ctl[i].Left = 100;
                this.Controls.Add(ctl[i]);
            }
        }
    }
}
