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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            HastaKayıt hskayıt = new HastaKayıt();
            hskayıt.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            TedaviPanel tedavi=new TedaviPanel();
            tedavi.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            RandevuPanel rndpnl=new RandevuPanel();
            rndpnl.Show();
            this.Hide();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            RecetePanel rctpnl =new RecetePanel();
            rctpnl.Show();
            this.Hide();
        }
    }
}
