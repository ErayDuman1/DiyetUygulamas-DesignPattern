using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DiyetUygulamasi
{
    class YesilliklerDunyasi:IDiyet
    {
        SqlCon connection = new SqlCon();
        private int diyetID = 4;
        private string diyetAdi = "Yeşillikler Dünyası";
        private string diyetListesi = "Yeşillikler Dünyası Diyet Listesi";
        public int DiyetID { get { return diyetID; } set { diyetID = value; } }
        public string DiyetAdi { get { return diyetAdi; } set { diyetAdi = value; } }
        public string DiyetListesi { get { return diyetListesi; } set { diyetListesi = value; } }
        public void DiyetAta(double HastaTc)
        {
            SqlCommand diyetAta = new SqlCommand
            {
                Connection = connection.SqlConnect(),
                CommandText = "update tblHasta set DiyetID = " + diyetID + " where HastaTC = " + HastaTc
            };
            diyetAta.ExecuteNonQuery();
            connection.SqlConnect().Close();
        }
    }
}
