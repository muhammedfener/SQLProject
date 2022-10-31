using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaglantiTest_Click(object sender, EventArgs e)
        {
            string baglantiAdresi = "Server=.;Database=NorqwehWind;Trusted_Connection=True;";
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = baglantiAdresi;

            baglanti.Open();

            lblBaglanti.Text = "Bağlantı Başarılı";

            baglanti.Close();
        }
    }
}
