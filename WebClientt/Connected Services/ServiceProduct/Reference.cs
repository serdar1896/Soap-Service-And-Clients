﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClientt.ServiceProduct {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Urunler", Namespace="http://schemas.datacontract.org/2004/07/Data")]
    [System.SerializableAttribute()]
    public partial class Urunler : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> BirimFiyatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KategoriAdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SatılamazField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TedarikciAdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TedarikciIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UrunAdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UrunIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> BirimFiyat {
            get {
                return this.BirimFiyatField;
            }
            set {
                if ((this.BirimFiyatField.Equals(value) != true)) {
                    this.BirimFiyatField = value;
                    this.RaisePropertyChanged("BirimFiyat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string KategoriAd {
            get {
                return this.KategoriAdField;
            }
            set {
                if ((object.ReferenceEquals(this.KategoriAdField, value) != true)) {
                    this.KategoriAdField = value;
                    this.RaisePropertyChanged("KategoriAd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Satılamaz {
            get {
                return this.SatılamazField;
            }
            set {
                if ((this.SatılamazField.Equals(value) != true)) {
                    this.SatılamazField = value;
                    this.RaisePropertyChanged("Satılamaz");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TedarikciAd {
            get {
                return this.TedarikciAdField;
            }
            set {
                if ((object.ReferenceEquals(this.TedarikciAdField, value) != true)) {
                    this.TedarikciAdField = value;
                    this.RaisePropertyChanged("TedarikciAd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TedarikciId {
            get {
                return this.TedarikciIdField;
            }
            set {
                if ((this.TedarikciIdField.Equals(value) != true)) {
                    this.TedarikciIdField = value;
                    this.RaisePropertyChanged("TedarikciId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UrunAd {
            get {
                return this.UrunAdField;
            }
            set {
                if ((object.ReferenceEquals(this.UrunAdField, value) != true)) {
                    this.UrunAdField = value;
                    this.RaisePropertyChanged("UrunAd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UrunId {
            get {
                return this.UrunIdField;
            }
            set {
                if ((this.UrunIdField.Equals(value) != true)) {
                    this.UrunIdField = value;
                    this.RaisePropertyChanged("UrunId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDTO", Namespace="http://schemas.datacontract.org/2004/07/Data")]
    [System.SerializableAttribute()]
    public partial class UserDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SupplierIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SupplierId {
            get {
                return this.SupplierIdField;
            }
            set {
                if ((this.SupplierIdField.Equals(value) != true)) {
                    this.SupplierIdField = value;
                    this.RaisePropertyChanged("SupplierId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceProduct.IServiceProduct")]
    public interface IServiceProduct {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/GetProducts", ReplyAction="http://tempuri.org/IServiceProduct/GetProductsResponse")]
        WebClientt.ServiceProduct.Urunler[] GetProducts(int SupplierId, string Role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/GetProducts", ReplyAction="http://tempuri.org/IServiceProduct/GetProductsResponse")]
        System.Threading.Tasks.Task<WebClientt.ServiceProduct.Urunler[]> GetProductsAsync(int SupplierId, string Role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/GetProductsWin", ReplyAction="http://tempuri.org/IServiceProduct/GetProductsWinResponse")]
        WebClientt.ServiceProduct.Urunler[] GetProductsWin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/GetProductsWin", ReplyAction="http://tempuri.org/IServiceProduct/GetProductsWinResponse")]
        System.Threading.Tasks.Task<WebClientt.ServiceProduct.Urunler[]> GetProductsWinAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/DeleteProducts", ReplyAction="http://tempuri.org/IServiceProduct/DeleteProductsResponse")]
        void DeleteProducts(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/DeleteProducts", ReplyAction="http://tempuri.org/IServiceProduct/DeleteProductsResponse")]
        System.Threading.Tasks.Task DeleteProductsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/UpdatePriceANDName", ReplyAction="http://tempuri.org/IServiceProduct/UpdatePriceANDNameResponse")]
        void UpdatePriceANDName(int id, decimal fiyat, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/UpdatePriceANDName", ReplyAction="http://tempuri.org/IServiceProduct/UpdatePriceANDNameResponse")]
        System.Threading.Tasks.Task UpdatePriceANDNameAsync(int id, decimal fiyat, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/FindProducts", ReplyAction="http://tempuri.org/IServiceProduct/FindProductsResponse")]
        WebClientt.ServiceProduct.Urunler FindProducts(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/FindProducts", ReplyAction="http://tempuri.org/IServiceProduct/FindProductsResponse")]
        System.Threading.Tasks.Task<WebClientt.ServiceProduct.Urunler> FindProductsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/Login", ReplyAction="http://tempuri.org/IServiceProduct/LoginResponse")]
        WebClientt.ServiceProduct.UserDTO Login(string Email, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProduct/Login", ReplyAction="http://tempuri.org/IServiceProduct/LoginResponse")]
        System.Threading.Tasks.Task<WebClientt.ServiceProduct.UserDTO> LoginAsync(string Email, string Password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceProductChannel : WebClientt.ServiceProduct.IServiceProduct, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceProductClient : System.ServiceModel.ClientBase<WebClientt.ServiceProduct.IServiceProduct>, WebClientt.ServiceProduct.IServiceProduct {
        
        public ServiceProductClient() {
        }
        
        public ServiceProductClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceProductClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceProductClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceProductClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebClientt.ServiceProduct.Urunler[] GetProducts(int SupplierId, string Role) {
            return base.Channel.GetProducts(SupplierId, Role);
        }
        
        public System.Threading.Tasks.Task<WebClientt.ServiceProduct.Urunler[]> GetProductsAsync(int SupplierId, string Role) {
            return base.Channel.GetProductsAsync(SupplierId, Role);
        }
        
        public WebClientt.ServiceProduct.Urunler[] GetProductsWin() {
            return base.Channel.GetProductsWin();
        }
        
        public System.Threading.Tasks.Task<WebClientt.ServiceProduct.Urunler[]> GetProductsWinAsync() {
            return base.Channel.GetProductsWinAsync();
        }
        
        public void DeleteProducts(int id) {
            base.Channel.DeleteProducts(id);
        }
        
        public System.Threading.Tasks.Task DeleteProductsAsync(int id) {
            return base.Channel.DeleteProductsAsync(id);
        }
        
        public void UpdatePriceANDName(int id, decimal fiyat, string name) {
            base.Channel.UpdatePriceANDName(id, fiyat, name);
        }
        
        public System.Threading.Tasks.Task UpdatePriceANDNameAsync(int id, decimal fiyat, string name) {
            return base.Channel.UpdatePriceANDNameAsync(id, fiyat, name);
        }
        
        public WebClientt.ServiceProduct.Urunler FindProducts(int id) {
            return base.Channel.FindProducts(id);
        }
        
        public System.Threading.Tasks.Task<WebClientt.ServiceProduct.Urunler> FindProductsAsync(int id) {
            return base.Channel.FindProductsAsync(id);
        }
        
        public WebClientt.ServiceProduct.UserDTO Login(string Email, string Password) {
            return base.Channel.Login(Email, Password);
        }
        
        public System.Threading.Tasks.Task<WebClientt.ServiceProduct.UserDTO> LoginAsync(string Email, string Password) {
            return base.Channel.LoginAsync(Email, Password);
        }
    }
}
