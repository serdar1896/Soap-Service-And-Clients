using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Web.UI.WebControls;
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
            DoldurDropDown();
            return View(pmodel);
        }
        [HttpPost]
        public ActionResult Update(ProductsModel model)
        {
            service.Update(model.SecUrun.UrunId,model.SecUrun);
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

        [UserAuthentication]
        public ActionResult Ekle()
        {
            DoldurDropDown();
            return View(pmodel);
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
        public void DoldurDropDown()
        {
            pmodel.CatDropDown = service.DoldurCombo().CatDropDown.Select(x => new SelectListItem
            {
                Text = x.KategoriAd,
                Value = x.KategoriId.ToString()
            }).ToList();
            pmodel.SupDropDown = service.DoldurCombo().SupDropDown.Select(x => new SelectListItem
            {
                Text = x.TedarikciAd,
                Value = x.TedarikciId.ToString()
            }).ToList();
        }
    }
}