﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YabanciMernisServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS", ConfigurationName="YabanciMernisServiceReference.KPSPublicYabanciDogrulaSoap")]
    public interface KPSPublicYabanciDogrulaSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tckimlik.nvi.gov.tr/WS/YabanciKimlikNoDogrula", ReplyAction="*")]
        System.Threading.Tasks.Task<YabanciMernisServiceReference.YabanciKimlikNoDogrulaResponse> YabanciKimlikNoDogrulaAsync(YabanciMernisServiceReference.YabanciKimlikNoDogrulaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class YabanciKimlikNoDogrulaRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="YabanciKimlikNoDogrula", Namespace="http://tckimlik.nvi.gov.tr/WS", Order=0)]
        public YabanciMernisServiceReference.YabanciKimlikNoDogrulaRequestBody Body;
        
        public YabanciKimlikNoDogrulaRequest()
        {
        }
        
        public YabanciKimlikNoDogrulaRequest(YabanciMernisServiceReference.YabanciKimlikNoDogrulaRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS")]
    public partial class YabanciKimlikNoDogrulaRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long KimlikNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Ad;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Soyad;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.Nullable<int> DogumGun;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public System.Nullable<int> DogumAy;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int DogumYil;
        
        public YabanciKimlikNoDogrulaRequestBody()
        {
        }
        
        public YabanciKimlikNoDogrulaRequestBody(long KimlikNo, string Ad, string Soyad, System.Nullable<int> DogumGun, System.Nullable<int> DogumAy, int DogumYil)
        {
            this.KimlikNo = KimlikNo;
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.DogumGun = DogumGun;
            this.DogumAy = DogumAy;
            this.DogumYil = DogumYil;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class YabanciKimlikNoDogrulaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="YabanciKimlikNoDogrulaResponse", Namespace="http://tckimlik.nvi.gov.tr/WS", Order=0)]
        public YabanciMernisServiceReference.YabanciKimlikNoDogrulaResponseBody Body;
        
        public YabanciKimlikNoDogrulaResponse()
        {
        }
        
        public YabanciKimlikNoDogrulaResponse(YabanciMernisServiceReference.YabanciKimlikNoDogrulaResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS")]
    public partial class YabanciKimlikNoDogrulaResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool YabanciKimlikNoDogrulaResult;
        
        public YabanciKimlikNoDogrulaResponseBody()
        {
        }
        
        public YabanciKimlikNoDogrulaResponseBody(bool YabanciKimlikNoDogrulaResult)
        {
            this.YabanciKimlikNoDogrulaResult = YabanciKimlikNoDogrulaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface KPSPublicYabanciDogrulaSoapChannel : YabanciMernisServiceReference.KPSPublicYabanciDogrulaSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class KPSPublicYabanciDogrulaSoapClient : System.ServiceModel.ClientBase<YabanciMernisServiceReference.KPSPublicYabanciDogrulaSoap>, YabanciMernisServiceReference.KPSPublicYabanciDogrulaSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public KPSPublicYabanciDogrulaSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(KPSPublicYabanciDogrulaSoapClient.GetBindingForEndpoint(endpointConfiguration), KPSPublicYabanciDogrulaSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public KPSPublicYabanciDogrulaSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(KPSPublicYabanciDogrulaSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public KPSPublicYabanciDogrulaSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(KPSPublicYabanciDogrulaSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public KPSPublicYabanciDogrulaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<YabanciMernisServiceReference.YabanciKimlikNoDogrulaResponse> YabanciKimlikNoDogrulaAsync(YabanciMernisServiceReference.YabanciKimlikNoDogrulaRequest request)
        {
            return base.Channel.YabanciKimlikNoDogrulaAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.KPSPublicYabanciDogrulaSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.KPSPublicYabanciDogrulaSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.KPSPublicYabanciDogrulaSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://tckimlik.nvi.gov.tr/Service/KPSPublicYabanciDogrula.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.KPSPublicYabanciDogrulaSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://tckimlik.nvi.gov.tr/Service/KPSPublicYabanciDogrula.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            KPSPublicYabanciDogrulaSoap,
            
            KPSPublicYabanciDogrulaSoap12,
        }
    }
}
