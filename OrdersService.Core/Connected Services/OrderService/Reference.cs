﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrdersService.Core.OrderService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/OrdersService.Common.Models")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private OrdersService.Core.OrderService.OrderStatus OrderStatusField;
        
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
        public System.DateTime CreationDate {
            get {
                return this.CreationDateField;
            }
            set {
                if ((this.CreationDateField.Equals(value) != true)) {
                    this.CreationDateField = value;
                    this.RaisePropertyChanged("CreationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OrdersService.Core.OrderService.OrderStatus OrderStatus {
            get {
                return this.OrderStatusField;
            }
            set {
                if ((this.OrderStatusField.Equals(value) != true)) {
                    this.OrderStatusField = value;
                    this.RaisePropertyChanged("OrderStatus");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderStatus", Namespace="http://schemas.datacontract.org/2004/07/OrdersService.Common.Models")]
    public enum OrderStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pending = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AwaitingPayment = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AwaitingFulfillment = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AwaitingShipment = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AwaitingPickup = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PartiallyShipped = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Completed = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Shipped = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Cancelled = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Declined = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Refunded = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Disputed = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ManualVerificationRequired = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PartiallyRefunded = 13,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/OrdersService.Common.Models")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/OrdersService.Common.Models")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderService.IOrderService")]
    public interface IOrderService {
        
        // CODEGEN: Generating message contract since the wrapper name (BaseRequest) of message BaseRequest does not match the default value (GetAllOrders)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetAllOrders", ReplyAction="http://tempuri.org/IOrderService/GetAllOrdersResponse")]
        OrdersService.Core.OrderService.OrdersListResponse GetAllOrders(OrdersService.Core.OrderService.BaseRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetAllOrders", ReplyAction="http://tempuri.org/IOrderService/GetAllOrdersResponse")]
        System.Threading.Tasks.Task<OrdersService.Core.OrderService.OrdersListResponse> GetAllOrdersAsync(OrdersService.Core.OrderService.BaseRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetOrderDetails", ReplyAction="http://tempuri.org/IOrderService/GetOrderDetailsResponse")]
        OrdersService.Core.OrderService.OrderDetailsResponse GetOrderDetails(OrdersService.Core.OrderService.GetOrderDetailsRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetOrderDetails", ReplyAction="http://tempuri.org/IOrderService/GetOrderDetailsResponse")]
        System.Threading.Tasks.Task<OrdersService.Core.OrderService.OrderDetailsResponse> GetOrderDetailsAsync(OrdersService.Core.OrderService.GetOrderDetailsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="BaseRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class BaseRequest {
        
        public BaseRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="OrdersListResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class OrdersListResponse {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public bool IsSuccess;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Message;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public OrdersService.Core.OrderService.Order[] Orders;
        
        public OrdersListResponse() {
        }
        
        public OrdersListResponse(bool IsSuccess, string Message, OrdersService.Core.OrderService.Order[] Orders) {
            this.IsSuccess = IsSuccess;
            this.Message = Message;
            this.Orders = Orders;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOrderDetailsRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetOrderDetailsRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public int RequestId;
        
        public GetOrderDetailsRequest() {
        }
        
        public GetOrderDetailsRequest(int RequestId) {
            this.RequestId = RequestId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="OrderDetailsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class OrderDetailsResponse {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public bool IsSuccess;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Message;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public OrdersService.Core.OrderService.Customer CustomerDetails;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public OrdersService.Core.OrderService.Item[] Items;
        
        public OrderDetailsResponse() {
        }
        
        public OrderDetailsResponse(bool IsSuccess, string Message, OrdersService.Core.OrderService.Customer CustomerDetails, OrdersService.Core.OrderService.Item[] Items) {
            this.IsSuccess = IsSuccess;
            this.Message = Message;
            this.CustomerDetails = CustomerDetails;
            this.Items = Items;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderServiceChannel : OrdersService.Core.OrderService.IOrderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderServiceClient : System.ServiceModel.ClientBase<OrdersService.Core.OrderService.IOrderService>, OrdersService.Core.OrderService.IOrderService {
        
        public OrderServiceClient() {
        }
        
        public OrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OrdersService.Core.OrderService.OrdersListResponse OrdersService.Core.OrderService.IOrderService.GetAllOrders(OrdersService.Core.OrderService.BaseRequest request) {
            return base.Channel.GetAllOrders(request);
        }
        
        public bool GetAllOrders(out string Message, out OrdersService.Core.OrderService.Order[] Orders) {
            OrdersService.Core.OrderService.BaseRequest inValue = new OrdersService.Core.OrderService.BaseRequest();
            OrdersService.Core.OrderService.OrdersListResponse retVal = ((OrdersService.Core.OrderService.IOrderService)(this)).GetAllOrders(inValue);
            Message = retVal.Message;
            Orders = retVal.Orders;
            return retVal.IsSuccess;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OrdersService.Core.OrderService.OrdersListResponse> OrdersService.Core.OrderService.IOrderService.GetAllOrdersAsync(OrdersService.Core.OrderService.BaseRequest request) {
            return base.Channel.GetAllOrdersAsync(request);
        }
        
        public System.Threading.Tasks.Task<OrdersService.Core.OrderService.OrdersListResponse> GetAllOrdersAsync() {
            OrdersService.Core.OrderService.BaseRequest inValue = new OrdersService.Core.OrderService.BaseRequest();
            return ((OrdersService.Core.OrderService.IOrderService)(this)).GetAllOrdersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OrdersService.Core.OrderService.OrderDetailsResponse OrdersService.Core.OrderService.IOrderService.GetOrderDetails(OrdersService.Core.OrderService.GetOrderDetailsRequest request) {
            return base.Channel.GetOrderDetails(request);
        }
        
        public bool GetOrderDetails(int RequestId, out string Message, out OrdersService.Core.OrderService.Customer CustomerDetails, out OrdersService.Core.OrderService.Item[] Items) {
            OrdersService.Core.OrderService.GetOrderDetailsRequest inValue = new OrdersService.Core.OrderService.GetOrderDetailsRequest();
            inValue.RequestId = RequestId;
            OrdersService.Core.OrderService.OrderDetailsResponse retVal = ((OrdersService.Core.OrderService.IOrderService)(this)).GetOrderDetails(inValue);
            Message = retVal.Message;
            CustomerDetails = retVal.CustomerDetails;
            Items = retVal.Items;
            return retVal.IsSuccess;
        }
        
        public System.Threading.Tasks.Task<OrdersService.Core.OrderService.OrderDetailsResponse> GetOrderDetailsAsync(OrdersService.Core.OrderService.GetOrderDetailsRequest request) {
            return base.Channel.GetOrderDetailsAsync(request);
        }
    }
}
