using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon2
{
    public partial class TedaviPanel : Form
    {
        public TedaviPanel()
        {
            InitializeComponent();
        }

        private void TedaviPanel_Load(object sender, EventArgs e)
        {
            uyeler();
            Reset();
        }
        private void filter()
        {
            Hastalar hs = new Hastalar();
            string query = "select * from TedaviTBL where TAd like '%" + guna2TextBox4.Text + "%'";
            DataSet ds = hs.ShowHasta(query);
            TedaviDGV.DataSource = ds.Tables[0];
        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        void uyeler()
        {
            Hastalar hs = new Hastalar();
            string query = "select * from TedaviTBL";
            DataSet ds = hs.ShowHasta(query);
            TedaviDGV.DataSource = ds.Tables[0];
        }
        void Reset()
        {
            txtaciklama.Text = "";
            txttedaviad.Text = "";
            txttutar.Text = "";
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string query = "insert into TedaviTBL values('" + txttedaviad.Text + "','" + txttutar.Text + "','" + txtaciklama.Text + "')";
            Hastalar hs = new Hastalar();
            try
            {
                hs.HastaEkle(query);
                MessageBox.Show("İşlem Başarıyla Kayıt Edildi");
                uyeler();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }
        int key = 0;
        private void btndüzenle_Click(object sender, EventArgs e)
        {
            Hastalar hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Güncellemek İstediğiniz İşlemi Seçin!");
            }
            else
            {
                try
                {
                    string query = "update TedaviTBL set TAd='" + txttedaviad.Text + "',TUcret='" + txttutar.Text + "',TAciklama='" + txtaciklama.Text + "' where TId=" + key + ";";
                    hs.HastaGuncelle(query);
                    MessageBox.Show("İşlem Başarıyla Güncellendi!!");
                    uyeler();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Hastalar hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silmek İstediğiniz İşlemi Seçin!");
            }
            else
            {
                try
                {
                    string query = "delete from TedaviTBL where TId=" + key + "";
                    hs.HastaSil(query);
                    MessageBox.Show("İşlem Başarıyla Silindi!");
                    uyeler();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void TedaviDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txttedaviad.Text = TedaviDGV.SelectedRows[0].Cells[1].Value.ToString();
            txttutar.Text = TedaviDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtaciklama.Text = TedaviDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (txttedaviad.Text == "")
            {
                key = 0;
            }
            else
                key = Convert.ToInt32(TedaviDGV.SelectedRows[0].Cells[0].Value.ToString());

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomePage home=new HomePage();
            home.Show();
            this.Hide();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
    }
}
