﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference2
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DashboardGen", Namespace="http://tempuri.org/")]
    public partial class DashboardGen : object
    {
        
        private string NOMBRE_UNIDADField;
        
        private int ID_TAREAField;
        
        private string NOMBRE_TAREAField;
        
        private string FECHA_TERMINOField;
        
        private System.DateTime FECHACREACIONField;
        
        private string FECHA_ACTUALField;
        
        private string FECHA_ESTIMADAField;
        
        private string ESTADOField;
        
        private int Rut_UsuField;
        
        private int Tareas_terField;
        
        private int Cant_tareas_totField;
        
        private int procentajeField;
        
        private string nombre_usurioField;
        
        private int ATRASOField;
        
        private ServiceReference2.DashboardGen[] listgenField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string NOMBRE_UNIDAD
        {
            get
            {
                return this.NOMBRE_UNIDADField;
            }
            set
            {
                this.NOMBRE_UNIDADField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int ID_TAREA
        {
            get
            {
                return this.ID_TAREAField;
            }
            set
            {
                this.ID_TAREAField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string NOMBRE_TAREA
        {
            get
            {
                return this.NOMBRE_TAREAField;
            }
            set
            {
                this.NOMBRE_TAREAField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string FECHA_TERMINO
        {
            get
            {
                return this.FECHA_TERMINOField;
            }
            set
            {
                this.FECHA_TERMINOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.DateTime FECHACREACION
        {
            get
            {
                return this.FECHACREACIONField;
            }
            set
            {
                this.FECHACREACIONField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string FECHA_ACTUAL
        {
            get
            {
                return this.FECHA_ACTUALField;
            }
            set
            {
                this.FECHA_ACTUALField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string FECHA_ESTIMADA
        {
            get
            {
                return this.FECHA_ESTIMADAField;
            }
            set
            {
                this.FECHA_ESTIMADAField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string ESTADO
        {
            get
            {
                return this.ESTADOField;
            }
            set
            {
                this.ESTADOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public int Rut_Usu
        {
            get
            {
                return this.Rut_UsuField;
            }
            set
            {
                this.Rut_UsuField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public int Tareas_ter
        {
            get
            {
                return this.Tareas_terField;
            }
            set
            {
                this.Tareas_terField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=10)]
        public int Cant_tareas_tot
        {
            get
            {
                return this.Cant_tareas_totField;
            }
            set
            {
                this.Cant_tareas_totField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=11)]
        public int procentaje
        {
            get
            {
                return this.procentajeField;
            }
            set
            {
                this.procentajeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string nombre_usurio
        {
            get
            {
                return this.nombre_usurioField;
            }
            set
            {
                this.nombre_usurioField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=13)]
        public int ATRASO
        {
            get
            {
                return this.ATRASOField;
            }
            set
            {
                this.ATRASOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=14)]
        public ServiceReference2.DashboardGen[] listgen
        {
            get
            {
                return this.listgenField;
            }
            set
            {
                this.listgenField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.ServiceProcessSoap")]
    public interface ServiceProcessSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference2.HelloWorldResponse> HelloWorldAsync(ServiceReference2.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference2.LoginResponse> LoginAsync(ServiceReference2.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DashBoard", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference2.DashBoardResponse> DashBoardAsync(ServiceReference2.DashBoardRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference2.HelloWorldRequestBody Body;
        
        public HelloWorldRequest()
        {
        }
        
        public HelloWorldRequest(ServiceReference2.HelloWorldRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody
    {
        
        public HelloWorldRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference2.HelloWorldResponseBody Body;
        
        public HelloWorldResponse()
        {
        }
        
        public HelloWorldResponse(ServiceReference2.HelloWorldResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody()
        {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult)
        {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Login", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference2.LoginRequestBody Body;
        
        public LoginRequest()
        {
        }
        
        public LoginRequest(ServiceReference2.LoginRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string usu;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pass;
        
        public LoginRequestBody()
        {
        }
        
        public LoginRequestBody(string usu, string pass)
        {
            this.usu = usu;
            this.pass = pass;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference2.LoginResponseBody Body;
        
        public LoginResponse()
        {
        }
        
        public LoginResponse(ServiceReference2.LoginResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string LoginResult;
        
        public LoginResponseBody()
        {
        }
        
        public LoginResponseBody(string LoginResult)
        {
            this.LoginResult = LoginResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DashBoardRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DashBoard", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference2.DashBoardRequestBody Body;
        
        public DashBoardRequest()
        {
        }
        
        public DashBoardRequest(ServiceReference2.DashBoardRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DashBoardRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int rut;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string rut_empresa;
        
        public DashBoardRequestBody()
        {
        }
        
        public DashBoardRequestBody(int rut, string rut_empresa)
        {
            this.rut = rut;
            this.rut_empresa = rut_empresa;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DashBoardResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DashBoardResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference2.DashBoardResponseBody Body;
        
        public DashBoardResponse()
        {
        }
        
        public DashBoardResponse(ServiceReference2.DashBoardResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DashBoardResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference2.DashboardGen[] DashBoardResult;
        
        public DashBoardResponseBody()
        {
        }
        
        public DashBoardResponseBody(ServiceReference2.DashboardGen[] DashBoardResult)
        {
            this.DashBoardResult = DashBoardResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ServiceProcessSoapChannel : ServiceReference2.ServiceProcessSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ServiceProcessSoapClient : System.ServiceModel.ClientBase<ServiceReference2.ServiceProcessSoap>, ServiceReference2.ServiceProcessSoap
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceProcessSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceProcessSoapClient.GetBindingForEndpoint(endpointConfiguration), ServiceProcessSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceProcessSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceProcessSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceProcessSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceProcessSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceProcessSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference2.HelloWorldResponse> ServiceReference2.ServiceProcessSoap.HelloWorldAsync(ServiceReference2.HelloWorldRequest request)
        {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.HelloWorldResponse> HelloWorldAsync()
        {
            ServiceReference2.HelloWorldRequest inValue = new ServiceReference2.HelloWorldRequest();
            inValue.Body = new ServiceReference2.HelloWorldRequestBody();
            return ((ServiceReference2.ServiceProcessSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference2.LoginResponse> ServiceReference2.ServiceProcessSoap.LoginAsync(ServiceReference2.LoginRequest request)
        {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.LoginResponse> LoginAsync(string usu, string pass)
        {
            ServiceReference2.LoginRequest inValue = new ServiceReference2.LoginRequest();
            inValue.Body = new ServiceReference2.LoginRequestBody();
            inValue.Body.usu = usu;
            inValue.Body.pass = pass;
            return ((ServiceReference2.ServiceProcessSoap)(this)).LoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference2.DashBoardResponse> ServiceReference2.ServiceProcessSoap.DashBoardAsync(ServiceReference2.DashBoardRequest request)
        {
            return base.Channel.DashBoardAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.DashBoardResponse> DashBoardAsync(int rut, string rut_empresa)
        {
            ServiceReference2.DashBoardRequest inValue = new ServiceReference2.DashBoardRequest();
            inValue.Body = new ServiceReference2.DashBoardRequestBody();
            inValue.Body.rut = rut;
            inValue.Body.rut_empresa = rut_empresa;
            return ((ServiceReference2.ServiceProcessSoap)(this)).DashBoardAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ServiceProcessSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.ServiceProcessSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ServiceProcessSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/LocalWs/ServiceProcess.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.ServiceProcessSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/LocalWs/ServiceProcess.asmx");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            ServiceProcessSoap,
            
            ServiceProcessSoap12,
        }
    }
}
