using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulamasi
{
    public interface IDiyet
    {
        int DiyetID { get; set; }           
        string DiyetAdi { get; set; }       //Diyet bilgilerini Property ile tanımlanır.
        string DiyetListesi { get; set; }
        void DiyetAta(double HastaTc);

    }
}
