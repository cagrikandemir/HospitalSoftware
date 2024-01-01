using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneOtomasyon2
{
    internal class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=ÇAĞRı;Initial Catalog=Hastane_Otomasyon;Integrated Security=True";
            return baglanti;
        }
    }
}
