// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Extensions;

    /// <summary>
    /// File Share configuration details, populated with information on storage configuration mounted on the VIS. The createAndMount
    /// option is selected in case of missing input.
    /// </summary>
    public partial class FileShareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IFileShareConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IFileShareConfigurationInternal
    {

        /// <summary>Backing field for <see cref="ConfigurationType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.ConfigurationType _configurationType;

        /// <summary>The type of file share config.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.ConfigurationType ConfigurationType { get => this._configurationType; set => this._configurationType = value; }

        /// <summary>Creates an new <see cref="FileShareConfiguration" /> instance.</summary>
        public FileShareConfiguration()
        {

        }
    }
    /// File Share configuration details, populated with information on storage configuration mounted on the VIS. The createAndMount
    /// option is selected in case of missing input.
    public partial interface IFileShareConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IJsonSerializable
    {
        /// <summary>The type of file share config.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of file share config.",
        SerializedName = @"configurationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.ConfigurationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.ConfigurationType ConfigurationType { get; set; }

    }
    /// File Share configuration details, populated with information on storage configuration mounted on the VIS. The createAndMount
    /// option is selected in case of missing input.
    internal partial interface IFileShareConfigurationInternal

    {
        /// <summary>The type of file share config.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.ConfigurationType ConfigurationType { get; set; }

    }
}