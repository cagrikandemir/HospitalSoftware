using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace HastaneOtomasyon2
{
    
    public partial class RandevuPanel : Form
    {
        public RandevuPanel()
        {
            InitializeComponent();
        }
        ConnectionString Mycon=new ConnectionString();
        private void fillHasta()
        {
            SqlConnection baglanti = Mycon.GetCon();
            baglanti.Open();
            SqlCommand komut=new SqlCommand("select HAd from HastaTBL ",baglanti);
            SqlDataReader rdr;
            rdr= komut.ExecuteReader();
            DataTable dt= new DataTable();
            dt.Columns.Add("HAd",typeof(string));
            dt.Load(rdr);
            comboadsoyad.ValueMember = "HAd";
            comboadsoyad.DataSource = dt;
            baglanti.Close();
        }
        private void fillTedavi()
        {
            SqlConnection baglanti = Mycon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select TAd from TedaviTBL ", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TAd", typeof(string));
            dt.Load(rdr);
            combotedavi.ValueMember = "TAd";
            combotedavi.DataSource = dt;
            baglanti.Close();


        }

        private void RandevuPanel_Load(object sender, EventArgs e)
        {
            fillHasta();
            fillTedavi();
            uyeler();
        }
        void uyeler()
        {
            Hastalar hs = new Hastalar();
            string query = "select * from RandevuTBL";
            DataSet ds = hs.ShowHasta(query);
            RandevuDGV.DataSource = ds.Tables[0];
        }
        void Reset()
        {
            comboadsoyad.SelectedIndex = -1;
            combotedavi.SelectedIndex = -1;
            datetarih.Text = "";
            combosaat.SelectedValue = "";

        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string query = "insert into RandevuTBL values('" + comboadsoyad.SelectedValue.ToString() + "','" + combotedavi.SelectedValue.ToString()+ "','" + datetarih.Text + "','"+combosaat.Text+ "')";
            Hastalar hs = new Hastalar();
            try
            {
                hs.HastaEkle(query);
                MessageBox.Show("Randevu Başarıyla Kayıt Edildi");
                uyeler();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }
        int key = 0;
        private void btnduzenle_Click(object sender, EventArgs e)
        {
            Hastalar hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Güncellemek İstediğiniz Randevu Seçin!");
            }
            else
            {
                try
                {
                    string query = "update RandevuTBL set Hasta='" + comboadsoyad.SelectedValue.ToString() + "',Tedavi='" + combotedavi.SelectedValue.ToString() + "',RTarih='" + datetarih.Text + "',RSaat='"+combosaat.Text+"' where RId=" + key + ";";
                    hs.HastaGuncelle(query);
                    MessageBox.Show("Randevu Başarıyla Güncellendi!!");
                    uyeler();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void RandevuDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboadsoyad.SelectedValue = RandevuDGV.SelectedRows[0].Cells[1].Value.ToString();
            combotedavi.SelectedValue = RandevuDGV.SelectedRows[0].Cells[2].Value.ToString();
            datetarih.Text = RandevuDGV.SelectedRows[0].Cells[3].Value.ToString();
            combosaat.SelectedItem = RandevuDGV.SelectedRows[0].Cells[4].Value.ToString();
            
            if (comboadsoyad.SelectedIndex== -1)
            {
                key = 0;
            }
            else
                key = Convert.ToInt32(RandevuDGV.SelectedRows[0].Cells[0].Value.ToString());

        }

        private void combosaat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Hastalar hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silmek İstediğiniz Randevu Seçin!");
            }
            else
            {
                try
                {
                    string query = "delete from RandevuTBL where RId=" + key + "";
                    hs.HastaSil(query);
                    MessageBox.Show("Randevu Başarıyla Silindi!");
                    uyeler();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }
    }
}
