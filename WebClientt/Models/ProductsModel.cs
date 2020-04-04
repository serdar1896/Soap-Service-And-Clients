using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClientt.ServiceProduct;

namespace WebClientt.Models
{
    public class ProductsModel
    {
        public Urunler SecUrun { get; set; }
        public List<Urunler> ulist { get; set; }
        public Urunler Urun { get; set; }
        public List<SelectListItem> CatDropDown { get; set; }
        public List<SelectListItem> SupDropDown { get; set; }
    }
}