using Guna.UI2.WinForms;
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

namespace HastaneOtomasyon2
{
    public partial class RecetePanel : Form
    {
        public RecetePanel()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomePage home=new HomePage();
            home.Show();
            this.Hide();
        }
        ConnectionString Mycon = new ConnectionString();
        private void fillHasta()
        {
            SqlConnection baglanti = Mycon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select HAd from HastaTBL ", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("HAd", typeof(string));
            dt.Load(rdr);
            comboadsoyad.ValueMember = "HAd";
            comboadsoyad.DataSource = dt;
            baglanti.Close();
        }
        private void fillTedavi()
        {
            SqlConnection baglanti = Mycon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from RandevuTBL where Hasta='"+comboadsoyad.SelectedValue.ToString()+"' ", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txttedaviad.Text = dr["Tedavi"].ToString();
            }
            baglanti.Close();
        }
        private void ucret()
        {
            SqlConnection baglanti=Mycon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TedaviTBL where TAd='"+txttedaviad.Text+"'", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(komut);
            sqlData.Fill(dt);
            foreach (DataRow dr  in dt.Rows)
            {
                txttutar.Text = dr["TUcret"].ToString();
            }
            baglanti.Close();
        }
        private void filter()
        {
            Hastalar hs = new Hastalar();
            string query = "select * from ReceteTBL where HasAd like '%" + txtara.Text + "%'";
            DataSet ds = hs.ShowHasta(query);
            RECETEDGV.DataSource = ds.Tables[0];
        }
        private void RecetePanel_Load(object sender, EventArgs e)
        {
            fillHasta();
            uyeler();
        }
        void uyeler()
        {
            Hastalar hs = new Hastalar();
            string query = "select * from ReceteTBL";
            DataSet ds = hs.ShowHasta(query);
            RECETEDGV.DataSource = ds.Tables[0];
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string query = "insert into ReceteTBL values('" + comboadsoyad.SelectedValue.ToString()+ "','" + txttedaviad.Text + "','" + txttutar.Text + "','"+txtilac.Text+"','"+txtmiktar.Text+"')";
            Hastalar hs = new Hastalar();
            try
            {
                hs.HastaEkle(query);
                MessageBox.Show("Reçete Başarıyla Hazırlandı");
                uyeler();
 
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        private void comboadsoyad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillTedavi();
        }
        Bitmap Bitmap;
        private void bnyazdir_Click(object sender, EventArgs e)
        {
            int height = RECETEDGV.Height;
            RECETEDGV.Height = RECETEDGV.RowCount * RECETEDGV.RowTemplate.Height * 2;
            Bitmap=new Bitmap(RECETEDGV.Width, RECETEDGV.Height);
            RECETEDGV.DrawToBitmap(Bitmap,new Rectangle(0,10,RECETEDGV.Width,RECETEDGV.Height));
            RECETEDGV.Height=height;
            printPreviewDialog1.ShowDialog();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Hastalar hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silmek İstediğiniz Reçeteyi Seçin!");
            }
            else
            {
                try
                {
                    string query = "delete from ReceteTBl where RecId=" + key + "";
                    hs.HastaSil(query);
                    MessageBox.Show("Reçete Başarıyla Silindi!");
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void comboadsoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void txttutar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txttedaviad_TextChanged(object sender, EventArgs e)
        {
            ucret();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RECETEDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int key = 0;
        private void RECETEDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboadsoyad.Text = RECETEDGV.SelectedRows[0].Cells[1].Value.ToString();
            txttedaviad.Text = RECETEDGV.SelectedRows[0].Cells[2].Value.ToString();
            txttutar.Text = RECETEDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtilac.Text = RECETEDGV.SelectedRows[0].Cells[4].Value.ToString();
            txtmiktar.Text = RECETEDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (txttedaviad.Text == "")
            {
                key = 0;
            }
            else
                key = Convert.ToInt32(RECETEDGV.SelectedRows[0].Cells[0].Value.ToString());

        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Bitmap, 0, 0);
        }
    }
}
