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
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public OrdersService.Core.OrderService.Order[] Orders;
        
        public OrdersListResponse() {
        }
        
        public OrdersListResponse(OrdersService.Core.OrderService.Order[] Orders) {
            this.Orders = Orders;
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
        
        public OrdersService.Core.OrderService.Order[] GetAllOrders() {
            OrdersService.Core.OrderService.BaseRequest inValue = new OrdersService.Core.OrderService.BaseRequest();
            OrdersService.Core.OrderService.OrdersListResponse retVal = ((OrdersService.Core.OrderService.IOrderService)(this)).GetAllOrders(inValue);
            return retVal.Orders;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OrdersService.Core.OrderService.OrdersListResponse> OrdersService.Core.OrderService.IOrderService.GetAllOrdersAsync(OrdersService.Core.OrderService.BaseRequest request) {
            return base.Channel.GetAllOrdersAsync(request);
        }
        
        public System.Threading.Tasks.Task<OrdersService.Core.OrderService.OrdersListResponse> GetAllOrdersAsync() {
            OrdersService.Core.OrderService.BaseRequest inValue = new OrdersService.Core.OrderService.BaseRequest();
            return ((OrdersService.Core.OrderService.IOrderService)(this)).GetAllOrdersAsync(inValue);
        }
    }
}