using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DiyetUygulamasi
{
    public class HTML:Cikti
    {
        public HTML(double TC)
        {
            hastaBilgi = new HastaBilgi().HastaBilgiAl(TC);
        }
        public override void DiyetBilgiCikti(StreamWriter sw, JsonWriter kullanilmiyor)
        {
            sw.WriteLine("<h2>Diyet Bilgileri</h2>");                   //Diyet bilgilerinin rapora yazdırıldığı kısım.
            sw.WriteLine("<p>Diyet Adı: <a name:'diyetAdi'>"+hastaBilgi.DiyetAd+"</a></p>");      
            sw.WriteLine("<p><b>Diyet Takvimi:</b></p>");
            sw.WriteLine("<p>Sabah: <a name:'diyetSabah'>"+hastaBilgi.DiyetListe[0]+"</a></p>");
            sw.WriteLine("<p>Öğle: <a name:'diyetOgle'>"+hastaBilgi.DiyetListe[1]+"</a></p>");
            sw.WriteLine("<p>Aksam: <a name:'diyetAksam'>"+hastaBilgi.DiyetListe[2]+"</a></p>");
        }
        public override void KisiselBilgiCikti(StreamWriter sw, JsonWriter kullanilmiyor)
        {
            sw.WriteLine("<h2>Hasta Bilgileri</h2>");                   //Hasta bilgilerinin rapora yazdırıldığı kısım.  
            sw.WriteLine("<p>Hasta TC: <a name:'hastaTC'>"+hastaBilgi.Tc+"</a></p>");
            sw.WriteLine("<p>Hasta: <a name:'hastaAdi'>"+hastaBilgi.Ad+"</a> <a name:'hastaSoyadi'>"+ hastaBilgi.Soyad + "</a></p>");
            sw.WriteLine("<p> Hastalık: <a name:'hastalikAd'>"+ hastaBilgi.HastalikAd + "</a></p>");
            sw.WriteLine("<p> Diyetisyen: <a name:'diyetisyenAd'>"+ hastaBilgi.DiyetisyenAd +"</a> <a name:'diyetisyenSoyad'>"+ hastaBilgi.DiyetisyenSoyad +"</a></p>");
        }
        public override void BilgiCikti()
        {
            string path = "rapor.html";
            File.WriteAllText(path, string.Empty);
            JsonWriter kullanilmiyor=null;
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))   
            {
                sw.WriteLine("<html>");             //html başı
                sw.WriteLine("<head>");
                sw.WriteLine("<title>Rapor</title>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");

                KisiselBilgiCikti(sw, kullanilmiyor);
                sw.WriteLine("</br>");
                DiyetBilgiCikti(sw, kullanilmiyor);
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");            //html sonu
                sw.Close();
            }
            fs.Close();
            
        }
        public override void BilgiCiktiTers()
        {
            string path = "rapor.html";
            File.WriteAllText(path, string.Empty);
            JsonWriter kullanilmiyor = null;
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<title>Rapor</title>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");

                DiyetBilgiCikti(sw, kullanilmiyor);
                sw.WriteLine("</br>");
                KisiselBilgiCikti(sw, kullanilmiyor);

                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
                sw.Close();
            }
            fs.Close();
        }
    }
}