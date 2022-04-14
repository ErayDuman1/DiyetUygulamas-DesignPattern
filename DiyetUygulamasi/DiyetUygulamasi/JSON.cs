using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DiyetUygulamasi
{
    public class JSON : Cikti
    {
        public JSON(double TC)
        {
            hastaBilgi = new HastaBilgi().HastaBilgiAl(TC);
        }
        public override void DiyetBilgiCikti(StreamWriter kullanilmiyor, JsonWriter writer)
        {
            writer.WritePropertyName("Diyet Bilgileri");         //Diyet Bilgileri tutan Json Object
            writer.WriteStartObject();
            {
                writer.WritePropertyName("Diyet Adı:");
                writer.WriteValue(hastaBilgi.DiyetAd);

                writer.WritePropertyName("Diyet Takvimi:");     //Diyet Takvim Bilgileri tutan Json Object
                writer.WriteStartObject();
                {
                    writer.WritePropertyName("Sabah:");
                    writer.WriteValue(hastaBilgi.DiyetListe[0]);

                    writer.WritePropertyName("Öğle:");
                    writer.WriteValue(hastaBilgi.DiyetListe[1]);

                    writer.WritePropertyName("Akşam:");
                    writer.WriteValue(hastaBilgi.DiyetListe[2]);
                }
                writer.WriteEndObject();
            }
        }
        public override void KisiselBilgiCikti(StreamWriter kullanilmiyor, JsonWriter writer)
        {
            writer.WritePropertyName("Hasta Bilgileri:");         //Hasta Bilgileri tutan Json Object
            writer.WriteStartObject();
            {
                writer.WritePropertyName("Hasta TC:");
                writer.WriteValue(hastaBilgi.Tc.ToString());

                writer.WritePropertyName("Hasta:");
                writer.WriteValue(hastaBilgi.Ad + " " + hastaBilgi.Soyad);

                writer.WritePropertyName("Hastalık:");
                writer.WriteValue(hastaBilgi.HastalikAd);

                writer.WritePropertyName("Diyetisyen:");
                writer.WriteValue(hastaBilgi.DiyetisyenAd + " " + hastaBilgi.DiyetisyenSoyad);
            }
            writer.WriteEndObject();
        }
        public override void BilgiCikti()
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sww = new StringWriter(sb);
            StreamWriter kullanilmiyor = null;
            using (JsonWriter writer = new JsonTextWriter(sww))
            {
                writer.Formatting = Formatting.Indented;

                writer.WriteStartObject();                  //Bütün Bilgileri tutan Json Object
                {
                    KisiselBilgiCikti(kullanilmiyor, writer);
                    DiyetBilgiCikti(kullanilmiyor, writer);
                }
                writer.WriteEndObject();
            }
            string path = "rapor.json";
            File.WriteAllText(path, string.Empty);
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.Write(sww);
                sw.Close();
            }
            fs.Close();
        }
        public override void BilgiCiktiTers()
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sww = new StringWriter(sb);
            StreamWriter kullanilmiyor = null;
            using (JsonWriter writer = new JsonTextWriter(sww))
            {
                writer.Formatting = Formatting.Indented;

                writer.WriteStartObject();               //Bütün Bilgileri tutan Json Object
                {
                    DiyetBilgiCikti(kullanilmiyor, writer);
                    KisiselBilgiCikti(kullanilmiyor, writer);
                }
                writer.WriteEndObject();
            }
            string path = "rapor.json";
            File.WriteAllText(path, string.Empty);
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.Write(sww);
                sw.Close();
            }
            fs.Close();
        }
    }
}