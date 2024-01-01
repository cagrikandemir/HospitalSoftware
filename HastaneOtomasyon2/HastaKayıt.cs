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

namespace HastaneOtomasyon2
{
    public partial class HastaKayıt : Form
    {
        public HastaKayıt()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        void uyeler()
        {
            Hastalar hs = new Hastalar();
            string query = "select * from HastaTBL";
            DataSet ds = hs.ShowHasta(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        void Reset()
        {
            txtadsoyad.Text = "";
            txtadres.Text = "";
            txttelefon.Text = "";
            txtara.Text = "";
            combocinsiyet.SelectedItem = " ";
            combokangrubu.SelectedItem = " ";
        }
        private void HastaKayıt_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string query = "insert into HastaTBL values('" + txtadsoyad.Text + "','" + txttelefon.Text + "','" + txtadres.Text + "','" + datetarih.Text+ "','" + combocinsiyet.SelectedItem.ToString() + "','" + combokangrubu.SelectedItem.ToString() + "')";
            Hastalar hs = new Hastalar();
            try
            {
                hs.HastaEkle(query);
                MessageBox.Show("Hasta Başarıyla Kayıt Edildi");
                uyeler();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
               
            }
        }
        int key = 0;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtadsoyad.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txttelefon.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtadres.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            datetarih.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            combocinsiyet.SelectedItem = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            combokangrubu.SelectedItem = guna2DataGridView1.SelectedRows[0].Cells[6].Value.ToString();  
            
            if (txtadsoyad.Text == "")
            {
                key = 0;
            }
            else          
                key = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());        
        

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Hastalar hs = new Hastalar();
            if(key==0)
            {
                MessageBox.Show("Silmek İstediğiniz Hastayı Seçin!");
            }
            else
            {
                try
                {
                    string query = "delete from HastaTBL where HId=" + key + "";
                    hs.HastaSil(query);
                    MessageBox.Show("Hasta Başarıyla Silindi!");
                    uyeler();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    
                }
            }
            
        }

        private void btndüzen_Click(object sender, EventArgs e)
        {
            Hastalar hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Güncellemek İstediğiniz Hastayı Seçin!");
            }
            else
            {
                try
                {
                    string query = "update HastaTBL set HAd='"+txtadsoyad.Text+"',HTelefon='"+txttelefon.Text+"',HAdres='"+txtadres.Text+"',HDTarih='"+datetarih.Text+"',HCinsiyet='"+combocinsiyet.SelectedItem.ToString()+"',HKangrubu='"+combokangrubu.SelectedItem.ToString()+"' where HId=" + key + ";";
                    hs.HastaGuncelle(query);
                    MessageBox.Show("Hasta Başarıyla Güncellendi!!");
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
