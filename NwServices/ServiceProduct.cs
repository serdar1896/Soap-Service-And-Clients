using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Mvc;
using Data;

namespace NwServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.  
    public class ServiceProduct : IServiceProduct
    {
        NorthwindEntities  db = new NorthwindEntities();

        public void EntryProduct(Urunler urun)
        {
            Products p = new Products();
           // p.ProductID = Convert.ToInt32( db.Products.Select(x=>x.ProductID).Count())+1;
            p.Discontinued = false;
            p.UnitPrice = urun.BirimFiyat;
            p.ProductName = urun.UrunAd;
            p.SupplierID = urun.TedarikciId;
            p.CategoryID = urun.KategoriId;
          //  p.Categories.CategoryName = urun.KategoriAd;
            db.Entry(p).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }
        public void DeleteProducts(int id)
        {
            Products p = db.Products.Find(id);
            p.Discontinued = true;
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void Update(int id,Urunler urun)
        {
            Products p = db.Products.Find(id);
            p.UnitPrice = urun.BirimFiyat;
            p.ProductName = urun.UrunAd;
            p.CategoryID = urun.KategoriId;
            p.SupplierID = urun.TedarikciId;           
            db.SaveChanges();
        }
        //ÜrünAraveSeç
        public Urunler FindProducts(int id)
        {           
            Urunler u = new Urunler();           
            Products p = db.Products.Find(id);
            u.UrunId = p.ProductID;
            u.UrunAd = p.ProductName;
            u.KategoriAd = p.Categories.CategoryName;
            u.KategoriId = p.Categories.CategoryID;
            u.TedarikciAd = p.Suppliers.CompanyName;
            u.TedarikciId = p.Suppliers.SupplierID;
            u.BirimFiyat =(decimal) p.UnitPrice;
            u.Satılamaz = p.Discontinued;
            return u;
        }
        public ICollection<Urunler> GetProducts(int SuplierId, string Role)
        {
            //db.Configuration.LazyLoadingEnabled = false;
            //db.Configuration.ProxyCreationEnabled = false;
            if (Role == "Admin")
            {
                return db.Products.Select(x => new Urunler
                {
                    UrunId = x.ProductID,
                    KategoriAd = x.Categories.CategoryName,
                    TedarikciAd = x.Suppliers.CompanyName,
                    UrunAd = x.ProductName,
                    BirimFiyat = (decimal)x.UnitPrice,
                    Satılamaz = x.Discontinued,
                    TedarikciId = (int)x.SupplierID
                    
                }).Where(x => x.Satılamaz == false).ToList();
            }
            else
            {
                return db.Products.Select(x => new Urunler
                {
                    UrunId = x.ProductID,
                    KategoriAd = x.Categories.CategoryName,
                    TedarikciAd = x.Suppliers.CompanyName,
                    UrunAd = x.ProductName,
                    BirimFiyat = (decimal)x.UnitPrice,
                    Satılamaz = x.Discontinued,
                    TedarikciId = (int)x.SupplierID
                }).Where(x => x.Satılamaz == false && x.TedarikciId == SuplierId).ToList();
                //Tedarikçi sadece kendi ürünlerini görüntüülüyebilsin.
            }
        }
        public ICollection<Urunler>  GetProductsWin()
        {
            List<Urunler> ulist = db.Products.Select(x => new Urunler
            {
                Satılamaz = x.Discontinued,
                KategoriAd = x.Categories.CategoryName,
                TedarikciAd = x.Suppliers.CompanyName,
                BirimFiyat = (decimal)x.UnitPrice,
                UrunAd = x.ProductName,
                UrunId = x.ProductID,
                TedarikciId=x.Suppliers.SupplierID,
                KategoriId=x.Categories.CategoryID
            }).Where(x => x.Satılamaz == false).OrderBy(y => y.UrunId).ToList(); 
            return ulist;
        }
        public UserDTO Login(string Email, string Password)
        {
            UserDTO dTO = new UserDTO();
            Users user = new Users();            
            user = db.Users.Find(Email); 
            if(user!=null)
            {
                if (user.Password == Password && user.UserId == Email)
                {
                    dTO.UserId = user.UserId;
                    dTO.Role = user.Role;
                    dTO.SupplierId = user.SupplierId;
                    dTO.UserName = user.UserName;
                    return dTO;
                }
                else
                    return null;                
            }
            else
            {
                return null;
            }

        }

        public Doldur DoldurCombo()
        {
            Doldur d = new Doldur();
          d.CatDropDown=  db.Categories.Select(x => new Urunler
            {
                KategoriAd = x.CategoryName,
                KategoriId=x.CategoryID
            }).ToList();
            d.SupDropDown = db.Suppliers.Select(x => new Urunler
            {
                TedarikciAd = x.CompanyName,
                TedarikciId = x.SupplierID
            }).ToList();
            return d;
        }
    }
}
