﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkflowApp.SR_Service {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="lkup_JobTitle", Namespace="http://schemas.datacontract.org/2004/07/DAL")]
    [System.SerializableAttribute()]
    public partial class lkup_JobTitle : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.Guid> CreatedByField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> CreationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ModificationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.Guid> ModifiedByField;
        
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
        public System.Nullable<System.Guid> CreatedBy {
            get {
                return this.CreatedByField;
            }
            set {
                if ((this.CreatedByField.Equals(value) != true)) {
                    this.CreatedByField = value;
                    this.RaisePropertyChanged("CreatedBy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CreationDate {
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
        public System.Guid Id {
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
        public bool IsActive {
            get {
                return this.IsActiveField;
            }
            set {
                if ((this.IsActiveField.Equals(value) != true)) {
                    this.IsActiveField = value;
                    this.RaisePropertyChanged("IsActive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ModificationDate {
            get {
                return this.ModificationDateField;
            }
            set {
                if ((this.ModificationDateField.Equals(value) != true)) {
                    this.ModificationDateField = value;
                    this.RaisePropertyChanged("ModificationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.Guid> ModifiedBy {
            get {
                return this.ModifiedByField;
            }
            set {
                if ((this.ModifiedByField.Equals(value) != true)) {
                    this.ModifiedByField = value;
                    this.RaisePropertyChanged("ModifiedBy");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SR_Service.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DoWork", ReplyAction="http://tempuri.org/IService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DoWork", ReplyAction="http://tempuri.org/IService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/calc", ReplyAction="http://tempuri.org/IService/calcResponse")]
        int calc(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/calc", ReplyAction="http://tempuri.org/IService/calcResponse")]
        System.Threading.Tasks.Task<int> calcAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ShowAllJobTitles", ReplyAction="http://tempuri.org/IService/ShowAllJobTitlesResponse")]
        WorkflowApp.SR_Service.lkup_JobTitle[] ShowAllJobTitles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ShowAllJobTitles", ReplyAction="http://tempuri.org/IService/ShowAllJobTitlesResponse")]
        System.Threading.Tasks.Task<WorkflowApp.SR_Service.lkup_JobTitle[]> ShowAllJobTitlesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetWorkflowStepsbyObjectId", ReplyAction="http://tempuri.org/IService/GetWorkflowStepsbyObjectIdResponse")]
        System.Data.DataTable GetWorkflowStepsbyObjectId(System.Nullable<System.Guid> pObjectId, System.Nullable<System.Guid> PObjectTypeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetWorkflowStepsbyObjectId", ReplyAction="http://tempuri.org/IService/GetWorkflowStepsbyObjectIdResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetWorkflowStepsbyObjectIdAsync(System.Nullable<System.Guid> pObjectId, System.Nullable<System.Guid> PObjectTypeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCFInfo", ReplyAction="http://tempuri.org/IService/GetCFInfoResponse")]
        System.Data.DataTable GetCFInfo(System.Guid CFId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCFInfo", ReplyAction="http://tempuri.org/IService/GetCFInfoResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetCFInfoAsync(System.Guid CFId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WorkflowApp.SR_Service.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WorkflowApp.SR_Service.IService>, WorkflowApp.SR_Service.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public int calc(int x, int y) {
            return base.Channel.calc(x, y);
        }
        
        public System.Threading.Tasks.Task<int> calcAsync(int x, int y) {
            return base.Channel.calcAsync(x, y);
        }
        
        public WorkflowApp.SR_Service.lkup_JobTitle[] ShowAllJobTitles() {
            return base.Channel.ShowAllJobTitles();
        }
        
        public System.Threading.Tasks.Task<WorkflowApp.SR_Service.lkup_JobTitle[]> ShowAllJobTitlesAsync() {
            return base.Channel.ShowAllJobTitlesAsync();
        }
        
        public System.Data.DataTable GetWorkflowStepsbyObjectId(System.Nullable<System.Guid> pObjectId, System.Nullable<System.Guid> PObjectTypeId) {
            return base.Channel.GetWorkflowStepsbyObjectId(pObjectId, PObjectTypeId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetWorkflowStepsbyObjectIdAsync(System.Nullable<System.Guid> pObjectId, System.Nullable<System.Guid> PObjectTypeId) {
            return base.Channel.GetWorkflowStepsbyObjectIdAsync(pObjectId, PObjectTypeId);
        }
        
        public System.Data.DataTable GetCFInfo(System.Guid CFId) {
            return base.Channel.GetCFInfo(CFId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetCFInfoAsync(System.Guid CFId) {
            return base.Channel.GetCFInfoAsync(CFId);
        }
    }
}
