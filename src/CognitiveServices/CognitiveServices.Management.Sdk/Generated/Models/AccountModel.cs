// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Cognitive Services account Model.
    /// </summary>
    public partial class AccountModel : DeploymentModel
    {
        /// <summary>
        /// Initializes a new instance of the AccountModel class.
        /// </summary>
        public AccountModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountModel class.
        /// </summary>
        /// <param name="format">Deployment model format.</param>
        /// <param name="name">Deployment model name.</param>
        /// <param name="version">Deployment model version.</param>
        /// <param name="baseModel">Base Model Identifier.</param>
        /// <param name="maxCapacity">The max capacity.</param>
        /// <param name="capabilities">The capabilities.</param>
        /// <param name="finetuneCapabilities">The capabilities for finetune
        /// models.</param>
        /// <param name="lifecycleStatus">Model lifecycle status. Possible
        /// values include: 'GenerallyAvailable', 'Preview'</param>
        public AccountModel(string format = default(string), string name = default(string), string version = default(string), CallRateLimit callRateLimit = default(CallRateLimit), DeploymentModel baseModel = default(DeploymentModel), int? maxCapacity = default(int?), IDictionary<string, string> capabilities = default(IDictionary<string, string>), IDictionary<string, string> finetuneCapabilities = default(IDictionary<string, string>), ModelDeprecationInfo deprecation = default(ModelDeprecationInfo), string lifecycleStatus = default(string), SystemData systemData = default(SystemData))
            : base(format, name, version, callRateLimit)
        {
            BaseModel = baseModel;
            MaxCapacity = maxCapacity;
            Capabilities = capabilities;
            FinetuneCapabilities = finetuneCapabilities;
            Deprecation = deprecation;
            LifecycleStatus = lifecycleStatus;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets base Model Identifier.
        /// </summary>
        [JsonProperty(PropertyName = "baseModel")]
        public DeploymentModel BaseModel { get; set; }

        /// <summary>
        /// Gets or sets the max capacity.
        /// </summary>
        [JsonProperty(PropertyName = "maxCapacity")]
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// Gets or sets the capabilities.
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public IDictionary<string, string> Capabilities { get; set; }

        /// <summary>
        /// Gets or sets the capabilities for finetune models.
        /// </summary>
        [JsonProperty(PropertyName = "finetuneCapabilities")]
        public IDictionary<string, string> FinetuneCapabilities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deprecation")]
        public ModelDeprecationInfo Deprecation { get; set; }

        /// <summary>
        /// Gets or sets model lifecycle status. Possible values include:
        /// 'GenerallyAvailable', 'Preview'
        /// </summary>
        [JsonProperty(PropertyName = "lifecycleStatus")]
        public string LifecycleStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

    }
}
