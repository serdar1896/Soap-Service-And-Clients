using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NwServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceProduct
    {
        [OperationContract]
        void EntryProduct(Urunler urun);
        [OperationContract]
        ICollection<Urunler> GetProducts(int SupplierId, string Role);
        [OperationContract]
        ICollection<Urunler> GetProductsWin();
        [OperationContract]
        void DeleteProducts(int id);
        [OperationContract]
        void UpdatePriceANDName(int id, decimal? fiyat, string name);
        [OperationContract]
        Urunler FindProducts(int id);
        [OperationContract]
        UserDTO Login(string Email, string Password);

    }
}
