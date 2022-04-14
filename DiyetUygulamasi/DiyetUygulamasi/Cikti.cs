using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace DiyetUygulamasi
{
    public abstract class Cikti
    {
        protected HastaBilgi hastaBilgi;

        public HastaBilgi HastaBilgi
        {
            get { return HastaBilgi; }
        }

        public abstract void KisiselBilgiCikti(StreamWriter html,JsonWriter json);  //Hasta bilgilerinin rapora yazdırıldığı metot.
        public abstract void DiyetBilgiCikti(StreamWriter html, JsonWriter json);   //Hastanın diyet bilgilerinin rapora yazdırıldığı metot.
        public abstract void BilgiCikti();          //Sırasıyla kişi bilgileri ve diyet bilgilerinin rapora yazdırıldığı metot. 
        public abstract void BilgiCiktiTers();      //Sırasıyla diyet bilgileri ve kişi bilgilerinin rapora yazdırıldığı metot.

    }
}
