﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CONSUMOWEB.ServicioChamoy {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioChamoy.servicio_web_gtSoap")]
    public interface servicio_web_gtSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSListado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet WSListado();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSListado", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> WSListadoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSInsertar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void WSInsertar(string nombre, int lanzamento, string desarrollador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSInsertar", ReplyAction="*")]
        System.Threading.Tasks.Task WSInsertarAsync(string nombre, int lanzamento, string desarrollador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSModificar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void WSModificar(int id, string Nombre, int Lanzamiento, string desarrollador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSModificar", ReplyAction="*")]
        System.Threading.Tasks.Task WSModificarAsync(int id, string Nombre, int Lanzamiento, string desarrollador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSeliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void WSeliminar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSeliminar", ReplyAction="*")]
        System.Threading.Tasks.Task WSeliminarAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface servicio_web_gtSoapChannel : CONSUMOWEB.ServicioChamoy.servicio_web_gtSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class servicio_web_gtSoapClient : System.ServiceModel.ClientBase<CONSUMOWEB.ServicioChamoy.servicio_web_gtSoap>, CONSUMOWEB.ServicioChamoy.servicio_web_gtSoap {
        
        public servicio_web_gtSoapClient() {
        }
        
        public servicio_web_gtSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public servicio_web_gtSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public servicio_web_gtSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public servicio_web_gtSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet WSListado() {
            return base.Channel.WSListado();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> WSListadoAsync() {
            return base.Channel.WSListadoAsync();
        }
        
        public void WSInsertar(string nombre, int lanzamento, string desarrollador) {
            base.Channel.WSInsertar(nombre, lanzamento, desarrollador);
        }
        
        public System.Threading.Tasks.Task WSInsertarAsync(string nombre, int lanzamento, string desarrollador) {
            return base.Channel.WSInsertarAsync(nombre, lanzamento, desarrollador);
        }
        
        public void WSModificar(int id, string Nombre, int Lanzamiento, string desarrollador) {
            base.Channel.WSModificar(id, Nombre, Lanzamiento, desarrollador);
        }
        
        public System.Threading.Tasks.Task WSModificarAsync(int id, string Nombre, int Lanzamiento, string desarrollador) {
            return base.Channel.WSModificarAsync(id, Nombre, Lanzamiento, desarrollador);
        }
        
        public void WSeliminar(int id) {
            base.Channel.WSeliminar(id);
        }
        
        public System.Threading.Tasks.Task WSeliminarAsync(int id) {
            return base.Channel.WSeliminarAsync(id);
        }
    }
}
