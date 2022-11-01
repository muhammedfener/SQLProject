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
    public partial class Form2 : Form
    {
        
        SqlConnection con = new SqlConnection();
        Dictionary<int, string> MarkaListesi = new Dictionary<int, string>();
        Dictionary<int, string> ModelListesi = new Dictionary<int, string>();
        Dictionary<int, string> RenkListesi = new Dictionary<int, string>();
        Dictionary<int, string> EhliyetListesi = new Dictionary<int, string>();
        Dictionary<int, string> VitesTipleri = new Dictionary<int, string>();
        int baglantiIstekSayisi = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ConnectionCreate();
            MarkaDoldur();
            RenkDoldur();
            EhliyetDoldur();
            VitesDoldur();
        }

        private void BaglantiSayac()
        {
            baglantiIstekSayisi += 1;
            if(baglantiIstekSayisi > 50)
            {
                con.Close();
                ConnectionCreate();
                baglantiIstekSayisi = 0;
            }
        }

        private void ConnectionCreate()
        {
            try
            {
                con.ConnectionString= "Server=DESKTOP-RN1H7KK\\SQLEXPRESS;Database=DB_OtoKiralama;Trusted_Connection=True;";
                
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına Bağlanırken Hata Oluştu! Hata Mesajı: " + ex.Message);
                con.Close();
            }
        }

        private void RenkDoldur()
        {
            SqlCommand com = new SqlCommand("SELECT RenkID,RenkAd FROM Renkler WHERE RenkAktifMi = 1", con);

            SqlDataReader Renkler = com.ExecuteReader();

            while (Renkler.Read())
            {
                RenkListesi.Add((int)Renkler[0], (string)Renkler[1]);
            }
            cmbRenkler.DataSource = RenkListesi.ToList();
            cmbRenkler.ValueMember = "Key";
            cmbRenkler.DisplayMember = "Value";

            Renkler.Close();
        }

        private void MarkaDoldur()
        {
            SqlCommand com = new SqlCommand("SELECT MarkaID,MarkaAd FROM Markalar WHERE MarkaAktifMi = 1", con);
            SqlDataReader Markalar = com.ExecuteReader();
            while (Markalar.Read())
            {
                MarkaListesi.Add((int) Markalar[0], (string) Markalar[1]);
            }
            cmbMarkalar.DataSource = MarkaListesi.ToList();
            cmbMarkalar.ValueMember = "Key";
            cmbMarkalar.DisplayMember = "Value";

            Markalar.Close();
        }

        private void ModelGetir(object sender, EventArgs e)
        {
            ModelListesi.Clear();

            SqlCommand com = new SqlCommand("SELECT ModelID,ModelAd FROM Modeller WHERE ModelAktifMi = 1 AND MarkaID = " + cmbMarkalar.SelectedValue, con);
            SqlDataReader Modeller = com.ExecuteReader();
            while (Modeller.Read())
            {
                ModelListesi.Add((int)Modeller[0], (string)Modeller[1]);
            }
            cmbModeller.DataSource = ModelListesi.ToList();
            cmbModeller.ValueMember = "Key";
            cmbModeller.DisplayMember = "Value";

            Modeller.Close();

        }

        private void EhliyetDoldur()
        {
            SqlCommand com = new SqlCommand("SELECT EhliyetID,EhliyetAd FROM Ehliyetler WHERE EhliyetAktifMi = 1", con);
            SqlDataReader Ehliyetler = com.ExecuteReader();

            while (Ehliyetler.Read())
            {
                EhliyetListesi.Add((int)Ehliyetler[0], (string)Ehliyetler[1]);
            }
            cmbEhliyetler.DataSource = EhliyetListesi.ToList();
            cmbEhliyetler.ValueMember = "Key";
            cmbEhliyetler.DisplayMember = "Value";

            Ehliyetler.Close();
        }

        private void VitesDoldur()
        {
            SqlCommand com = new SqlCommand("SELECT VitesTipiID,VitesTipiAd FROM VitesTipleri WHERE VitesTipiAktifMi = 1", con);
            SqlDataReader Vitesler = com.ExecuteReader();
            while (Vitesler.Read())
            {
                VitesTipleri.Add((int)Vitesler[0], (string)Vitesler[1]);
            }
            cmbVites.DataSource = VitesTipleri.ToList();
            cmbVites.ValueMember = "Key";
            cmbVites.DisplayMember = "Value";

            Vitesler.Close();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            int markaID = (int) cmbMarkalar.SelectedValue;
            int modelID = (int) cmbModeller.SelectedValue;
            int renkID = (int) cmbRenkler.SelectedValue;
            decimal gunlukUcret = Convert.ToDecimal(txtGunlukUcret.Text);
            string plaka = txtPlaka.Text;
            string modelYil = txtModelYil.Text;
            int koltukSayisi = Convert.ToInt32(txtKoltukSayisi.Text);
            int depoHacmi = Convert.ToInt32(txtDepoHacim.Text);
            int ehliyetID = (int) cmbEhliyetler.SelectedValue;
            int kapiSayisi = Convert.ToInt32(txtKapiSayisi.Text);
            int vitesID = (int) cmbVites.SelectedValue;
            string aciklama = txtAciklama.Text;

            
            SqlCommand com = new SqlCommand("INSERT INTO Otomobiller (MarkaID,RenkID,ModelID,OtomobilGunlukUcret,OtomobilPlakaNo,OtomobilModelYili,OtomobilKoltukSayisi,OtomobilDepoHacmi,EhliyetID,OtomobilKapiSayisi,VitesTipiID,OtomobilAktifMi,OtomobilAciklama) VALUES(@markaID,@renkID,@modelID,@gunlukUcret,@plaka,@modelYil,@koltukSayisi,@depoHacmi,@ehliyetID,@kapiSayisi,@vitesID,1,@aciklama);", con);

            com.Parameters.AddWithValue("@markaID", markaID);
            com.Parameters.AddWithValue("@renkID", renkID);
            com.Parameters.AddWithValue("@modelID", modelID);
            com.Parameters.AddWithValue("@gunlukUcret", gunlukUcret);
            com.Parameters.AddWithValue("@plaka", plaka);
            com.Parameters.AddWithValue("@modelYil", modelYil);
            com.Parameters.AddWithValue("@koltukSayisi", koltukSayisi);
            com.Parameters.AddWithValue("@depoHacmi", depoHacmi);
            com.Parameters.AddWithValue("@ehliyetID", ehliyetID);
            com.Parameters.AddWithValue("@kapiSayisi", kapiSayisi);
            com.Parameters.AddWithValue("@vitesID", vitesID);
            com.Parameters.AddWithValue("@aciklama", aciklama);

            if (com.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Ekleme Başarılı");
            }
        }
    }
}
