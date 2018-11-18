﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task_1.AnimalService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AnimalService.AnimalService")]
    public interface AnimalService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AnimalService/GetByIdFromCache", ReplyAction="http://tempuri.org/AnimalService/GetByIdFromCacheResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Practice.Core.Insect))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Practice.Core.Butterfly))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Practice.Core.Spider))]
        Practice.Core.Animal GetByIdFromCache(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AnimalService/GetByIdFromCache", ReplyAction="http://tempuri.org/AnimalService/GetByIdFromCacheResponse")]
        System.Threading.Tasks.Task<Practice.Core.Animal> GetByIdFromCacheAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AnimalService/Save", ReplyAction="http://tempuri.org/AnimalService/SaveResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Practice.Core.Insect))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Practice.Core.Butterfly))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Practice.Core.Spider))]
        Practice.Core.Animal Save(Practice.Core.Animal animal, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AnimalService/Save", ReplyAction="http://tempuri.org/AnimalService/SaveResponse")]
        System.Threading.Tasks.Task<Practice.Core.Animal> SaveAsync(Practice.Core.Animal animal, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AnimalService/Animals", ReplyAction="http://tempuri.org/AnimalService/AnimalsResponse")]
        System.Collections.Generic.List<Practice.Core.Animal> Animals();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AnimalService/Animals", ReplyAction="http://tempuri.org/AnimalService/AnimalsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Practice.Core.Animal>> AnimalsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AnimalServiceChannel : Task_1.AnimalService.AnimalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AnimalServiceClient : System.ServiceModel.ClientBase<Task_1.AnimalService.AnimalService>, Task_1.AnimalService.AnimalService {
        
        public AnimalServiceClient() {
        }
        
        public AnimalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AnimalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AnimalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AnimalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Practice.Core.Animal GetByIdFromCache(int id) {
            return base.Channel.GetByIdFromCache(id);
        }
        
        public System.Threading.Tasks.Task<Practice.Core.Animal> GetByIdFromCacheAsync(int id) {
            return base.Channel.GetByIdFromCacheAsync(id);
        }
        
        public Practice.Core.Animal Save(Practice.Core.Animal animal, int id) {
            return base.Channel.Save(animal, id);
        }
        
        public System.Threading.Tasks.Task<Practice.Core.Animal> SaveAsync(Practice.Core.Animal animal, int id) {
            return base.Channel.SaveAsync(animal, id);
        }
        
        public System.Collections.Generic.List<Practice.Core.Animal> Animals() {
            return base.Channel.Animals();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Practice.Core.Animal>> AnimalsAsync() {
            return base.Channel.AnimalsAsync();
        }
    }
}
