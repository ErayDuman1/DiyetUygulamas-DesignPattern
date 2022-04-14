using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DiyetUygulamasi
{
    public class HastaBilgi
    {
        SqlCon connection = new SqlCon();
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Tc { get; set; }          
        public string HastalikAd { get; set; }          //Hastanın bilgileri property ile atanır.
        public string DiyetisyenAd { get; set; }
        public string DiyetisyenSoyad { get; set; }
        public string DiyetAd { get; set; }

        public string[] DiyetListe = new string[3];

        public HastaBilgi HastaBilgiAl(double hastaTC)          
        {
            HastaBilgi hasta = new HastaBilgi();
            SqlCommand komut = new SqlCommand           //HastaBilgiAl procedurenden çekilen veriler yukarıdaki propertylere atanır.
            {
                Connection = connection.SqlConnect(),
                CommandText = "execute HastaBilgiAl "+ hastaTC
            };
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                hasta.Tc = Convert.ToDouble(dr["HastaTC"].ToString());
                hasta.Ad = dr["HastaAd"].ToString();
                hasta.Soyad = dr["HastaSoyad"].ToString();
                hasta.HastalikAd = dr["HastalikAd"].ToString();
                hasta.DiyetisyenAd = dr["DiyetisyenAd"].ToString();
                hasta.DiyetisyenSoyad = dr["DiyetisyenSoyad"].ToString();
                hasta.DiyetAd = dr["DiyetAd"].ToString();
                hasta.DiyetListe[0] = dr["Sabah"].ToString();
                hasta.DiyetListe[1] = dr["Ogle"].ToString();
                hasta.DiyetListe[2] = dr["Aksam"].ToString();
            }
            return hasta;
        }

    }
}
