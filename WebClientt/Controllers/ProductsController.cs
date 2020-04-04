using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using WebClientt.Models;
using WebClientt.ServiceProduct;

namespace WebClientt.Controllers
{
    public class ProductsController : Controller
    {
        ProductsModel pmodel = new ProductsModel();
        ServiceProductClient service = new ServiceProductClient();
        // GET: Products

        [UserAuthentication] //login olmadan göremesin diye
        public ActionResult Products()
        {
            pmodel.ulist = service.GetProducts(Convert.ToInt32(Session["Supplier"]),
                Session["Role"].ToString()).ToList();
            return View(pmodel);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            pmodel.SecUrun = service.FindProducts(id);
            return View(pmodel);
        }
        [HttpPost]
        public ActionResult Update(ProductsModel model)
        {
            service.UpdatePriceANDName(model.SecUrun.UrunId, model.SecUrun.BirimFiyat, model.SecUrun.UrunAd);
            return RedirectToAction("Products");
        }
        //[HttpGet]
        //public ActionResult Sil(int id)
        //{
        //    pmodel.SecUrun = service.FindProducts(id);
        //    return View(pmodel);
        //}
  
        public ActionResult Sil(int id)
        {
            service.DeleteProducts(id);
            return RedirectToAction("Products");
        }
        [HttpGet]
        public ActionResult Ekle()
        {   
            return View(pmodel.SecUrun);;
        }
        [HttpPost]
        public ActionResult Ekle(ProductsModel model)
        {
            service.EntryProduct(model.SecUrun);
            return RedirectToAction("Products");
        }
        public ActionResult Ara(ProductsModel model,string name)
        {
        //   int id = pmodel.ulist.Select(x => x.UrunId)();
          Urunler urun = service.FindProducts(model.Urun.UrunId);
            if (urun != null)
            {
                Session["ProductName"] = urun.UrunAd;
                pmodel.SecUrun = service.FindProducts(model.SecUrun.UrunId);
            }
            return RedirectToAction("Products", "Products");
        }
    }
}