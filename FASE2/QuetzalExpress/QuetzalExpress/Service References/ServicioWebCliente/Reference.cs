﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuetzalExpress.ServicioWebCliente {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost/WebService", ConfigurationName="ServicioWebCliente.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name login from namespace http://localhost/WebService is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WebService/Insert_Usuario", ReplyAction="*")]
        QuetzalExpress.ServicioWebCliente.Insert_UsuarioResponse Insert_Usuario(QuetzalExpress.ServicioWebCliente.Insert_UsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WebService/Insert_Usuario", ReplyAction="*")]
        System.Threading.Tasks.Task<QuetzalExpress.ServicioWebCliente.Insert_UsuarioResponse> Insert_UsuarioAsync(QuetzalExpress.ServicioWebCliente.Insert_UsuarioRequest request);
        
        // CODEGEN: Generating message contract since element name login from namespace http://localhost/WebService is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WebService/rol", ReplyAction="*")]
        QuetzalExpress.ServicioWebCliente.rolResponse rol(QuetzalExpress.ServicioWebCliente.rolRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WebService/rol", ReplyAction="*")]
        System.Threading.Tasks.Task<QuetzalExpress.ServicioWebCliente.rolResponse> rolAsync(QuetzalExpress.ServicioWebCliente.rolRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Insert_UsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Insert_Usuario", Namespace="http://localhost/WebService", Order=0)]
        public QuetzalExpress.ServicioWebCliente.Insert_UsuarioRequestBody Body;
        
        public Insert_UsuarioRequest() {
        }
        
        public Insert_UsuarioRequest(QuetzalExpress.ServicioWebCliente.Insert_UsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost/WebService")]
    public partial class Insert_UsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string login;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pass;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string apellido;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string dpi;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string tefelono;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string direccion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string email;
        
        public Insert_UsuarioRequestBody() {
        }
        
        public Insert_UsuarioRequestBody(string login, string pass, string nombre, string apellido, string dpi, string tefelono, string direccion, string email) {
            this.login = login;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dpi = dpi;
            this.tefelono = tefelono;
            this.direccion = direccion;
            this.email = email;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Insert_UsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Insert_UsuarioResponse", Namespace="http://localhost/WebService", Order=0)]
        public QuetzalExpress.ServicioWebCliente.Insert_UsuarioResponseBody Body;
        
        public Insert_UsuarioResponse() {
        }
        
        public Insert_UsuarioResponse(QuetzalExpress.ServicioWebCliente.Insert_UsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class Insert_UsuarioResponseBody {
        
        public Insert_UsuarioResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class rolRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="rol", Namespace="http://localhost/WebService", Order=0)]
        public QuetzalExpress.ServicioWebCliente.rolRequestBody Body;
        
        public rolRequest() {
        }
        
        public rolRequest(QuetzalExpress.ServicioWebCliente.rolRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost/WebService")]
    public partial class rolRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string login;
        
        public rolRequestBody() {
        }
        
        public rolRequestBody(string login) {
            this.login = login;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class rolResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="rolResponse", Namespace="http://localhost/WebService", Order=0)]
        public QuetzalExpress.ServicioWebCliente.rolResponseBody Body;
        
        public rolResponse() {
        }
        
        public rolResponse(QuetzalExpress.ServicioWebCliente.rolResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost/WebService")]
    public partial class rolResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int rolResult;
        
        public rolResponseBody() {
        }
        
        public rolResponseBody(int rolResult) {
            this.rolResult = rolResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : QuetzalExpress.ServicioWebCliente.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<QuetzalExpress.ServicioWebCliente.WebServiceSoap>, QuetzalExpress.ServicioWebCliente.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        QuetzalExpress.ServicioWebCliente.Insert_UsuarioResponse QuetzalExpress.ServicioWebCliente.WebServiceSoap.Insert_Usuario(QuetzalExpress.ServicioWebCliente.Insert_UsuarioRequest request) {
            return base.Channel.Insert_Usuario(request);
        }
        
        public void Insert_Usuario(string login, string pass, string nombre, string apellido, string dpi, string tefelono, string direccion, string email) {
            QuetzalExpress.ServicioWebCliente.Insert_UsuarioRequest inValue = new QuetzalExpress.ServicioWebCliente.Insert_UsuarioRequest();
            inValue.Body = new QuetzalExpress.ServicioWebCliente.Insert_UsuarioRequestBody();
            inValue.Body.login = login;
            inValue.Body.pass = pass;
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.dpi = dpi;
            inValue.Body.tefelono = tefelono;
            inValue.Body.direccion = direccion;
            inValue.Body.email = email;
            QuetzalExpress.ServicioWebCliente.Insert_UsuarioResponse retVal = ((QuetzalExpress.ServicioWebCliente.WebServiceSoap)(this)).Insert_Usuario(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<QuetzalExpress.ServicioWebCliente.Insert_UsuarioResponse> QuetzalExpress.ServicioWebCliente.WebServiceSoap.Insert_UsuarioAsync(QuetzalExpress.ServicioWebCliente.Insert_UsuarioRequest request) {
            return base.Channel.Insert_UsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<QuetzalExpress.ServicioWebCliente.Insert_UsuarioResponse> Insert_UsuarioAsync(string login, string pass, string nombre, string apellido, string dpi, string tefelono, string direccion, string email) {
            QuetzalExpress.ServicioWebCliente.Insert_UsuarioRequest inValue = new QuetzalExpress.ServicioWebCliente.Insert_UsuarioRequest();
            inValue.Body = new QuetzalExpress.ServicioWebCliente.Insert_UsuarioRequestBody();
            inValue.Body.login = login;
            inValue.Body.pass = pass;
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.dpi = dpi;
            inValue.Body.tefelono = tefelono;
            inValue.Body.direccion = direccion;
            inValue.Body.email = email;
            return ((QuetzalExpress.ServicioWebCliente.WebServiceSoap)(this)).Insert_UsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        QuetzalExpress.ServicioWebCliente.rolResponse QuetzalExpress.ServicioWebCliente.WebServiceSoap.rol(QuetzalExpress.ServicioWebCliente.rolRequest request) {
            return base.Channel.rol(request);
        }
        
        public int rol(string login) {
            QuetzalExpress.ServicioWebCliente.rolRequest inValue = new QuetzalExpress.ServicioWebCliente.rolRequest();
            inValue.Body = new QuetzalExpress.ServicioWebCliente.rolRequestBody();
            inValue.Body.login = login;
            QuetzalExpress.ServicioWebCliente.rolResponse retVal = ((QuetzalExpress.ServicioWebCliente.WebServiceSoap)(this)).rol(inValue);
            return retVal.Body.rolResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<QuetzalExpress.ServicioWebCliente.rolResponse> QuetzalExpress.ServicioWebCliente.WebServiceSoap.rolAsync(QuetzalExpress.ServicioWebCliente.rolRequest request) {
            return base.Channel.rolAsync(request);
        }
        
        public System.Threading.Tasks.Task<QuetzalExpress.ServicioWebCliente.rolResponse> rolAsync(string login) {
            QuetzalExpress.ServicioWebCliente.rolRequest inValue = new QuetzalExpress.ServicioWebCliente.rolRequest();
            inValue.Body = new QuetzalExpress.ServicioWebCliente.rolRequestBody();
            inValue.Body.login = login;
            return ((QuetzalExpress.ServicioWebCliente.WebServiceSoap)(this)).rolAsync(inValue);
        }
    }
}
