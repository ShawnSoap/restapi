//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MS.Support.CMATGateway.Proxy.STS
{
    using System.Runtime.Serialization;
    using System;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Limit", Namespace = "http://schemas.datacontract.org/2004/07/Microsoft.Supportability.CcpSTS.Limits")]
    [System.SerializableAttribute()]
    public partial class Limit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                if ((object.ReferenceEquals(this.TypeField, value) != true))
                {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ValueField, value) != true))
                {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "STS.IResourceLimits")]
    public interface IResourceLimits
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IResourceLimits/GetLimits", ReplyAction = "http://tempuri.org/IResourceLimits/GetLimitsResponse")]
        MS.Support.CMATGateway.Proxy.STS.Limit[] GetLimits(string userID, string realmName, string parentRightName);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IResourceLimitsChannel : MS.Support.CMATGateway.Proxy.STS.IResourceLimits, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ResourceLimitsClient : System.ServiceModel.ClientBase<MS.Support.CMATGateway.Proxy.STS.IResourceLimits>, MS.Support.CMATGateway.Proxy.STS.IResourceLimits
    {

        public ResourceLimitsClient()
        {
        }

        public ResourceLimitsClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public ResourceLimitsClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ResourceLimitsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ResourceLimitsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public MS.Support.CMATGateway.Proxy.STS.Limit[] GetLimits(string userID, string realmName, string parentRightName)
        {
            return base.Channel.GetLimits(userID, realmName, parentRightName);
        }
    }
}
