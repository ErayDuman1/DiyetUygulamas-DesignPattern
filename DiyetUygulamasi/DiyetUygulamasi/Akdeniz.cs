using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DiyetUygulamasi
{
    class Akdeniz:IDiyet
    {
        SqlCon connection = new SqlCon();
        private int diyetID = 1;
        private string diyetAdi = "Akdeniz";
        private string diyetListesi = "Akdeniz Diyet Listesi:";
        public int DiyetID { get { return diyetID; } set { diyetID = value; } }         
        public string DiyetAdi { get { return diyetAdi; } set { diyetAdi = value; } }
        public string DiyetListesi { get { return diyetListesi; } set { diyetListesi = value; } }
        public void DiyetAta(double HastaTc)
        {
            SqlCommand diyetAta = new SqlCommand                //tblHasta tableındaki hastanın diyeti atanır.
            {
                Connection = connection.SqlConnect(),
                CommandText = "update tblHasta set DiyetID = " + diyetID + " where HastaTC = " + HastaTc
            };
            diyetAta.ExecuteNonQuery();
            connection.SqlConnect().Close();
        }
    }
}
