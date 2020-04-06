using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Data
{
    public  class Urunler
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public string KategoriAd { get; set; }
        public int? KategoriId { get; set; }
        public int TedarikciId { get; set; }
        public string TedarikciAd { get; set; }
        public decimal? BirimFiyat { get; set; }
        public bool Satılamaz { get; set; }

      
    }
}
