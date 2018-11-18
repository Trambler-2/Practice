﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task_1.SquadService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AnimalType", Namespace="http://schemas.datacontract.org/2004/07/Service.DAL")]
    [System.SerializableAttribute()]
    public partial class AnimalType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practice.Core.Animal[] AnimalsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practice.Core.SQUAD TypeField;
        
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
        public Practice.Core.Animal[] Animals {
            get {
                return this.AnimalsField;
            }
            set {
                if ((object.ReferenceEquals(this.AnimalsField, value) != true)) {
                    this.AnimalsField = value;
                    this.RaisePropertyChanged("Animals");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practice.Core.SQUAD Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SquadService.SquadService")]
    public interface SquadService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SquadService/GetByIdFromCache", ReplyAction="http://tempuri.org/SquadService/GetByIdFromCacheResponse")]
        Task_1.SquadService.AnimalType GetByIdFromCache(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SquadService/GetByIdFromCache", ReplyAction="http://tempuri.org/SquadService/GetByIdFromCacheResponse")]
        System.Threading.Tasks.Task<Task_1.SquadService.AnimalType> GetByIdFromCacheAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SquadService/Save", ReplyAction="http://tempuri.org/SquadService/SaveResponse")]
        Task_1.SquadService.AnimalType Save(Task_1.SquadService.AnimalType squad, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SquadService/Save", ReplyAction="http://tempuri.org/SquadService/SaveResponse")]
        System.Threading.Tasks.Task<Task_1.SquadService.AnimalType> SaveAsync(Task_1.SquadService.AnimalType squad, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SquadService/Squads", ReplyAction="http://tempuri.org/SquadService/SquadsResponse")]
        Task_1.SquadService.AnimalType[] Squads();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SquadService/Squads", ReplyAction="http://tempuri.org/SquadService/SquadsResponse")]
        System.Threading.Tasks.Task<Task_1.SquadService.AnimalType[]> SquadsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SquadServiceChannel : Task_1.SquadService.SquadService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SquadServiceClient : System.ServiceModel.ClientBase<Task_1.SquadService.SquadService>, Task_1.SquadService.SquadService {
        
        public SquadServiceClient() {
        }
        
        public SquadServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SquadServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SquadServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SquadServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Task_1.SquadService.AnimalType GetByIdFromCache(int id) {
            return base.Channel.GetByIdFromCache(id);
        }
        
        public System.Threading.Tasks.Task<Task_1.SquadService.AnimalType> GetByIdFromCacheAsync(int id) {
            return base.Channel.GetByIdFromCacheAsync(id);
        }
        
        public Task_1.SquadService.AnimalType Save(Task_1.SquadService.AnimalType squad, int id) {
            return base.Channel.Save(squad, id);
        }
        
        public System.Threading.Tasks.Task<Task_1.SquadService.AnimalType> SaveAsync(Task_1.SquadService.AnimalType squad, int id) {
            return base.Channel.SaveAsync(squad, id);
        }
        
        public Task_1.SquadService.AnimalType[] Squads() {
            return base.Channel.Squads();
        }
        
        public System.Threading.Tasks.Task<Task_1.SquadService.AnimalType[]> SquadsAsync() {
            return base.Channel.SquadsAsync();
        }
    }
}
