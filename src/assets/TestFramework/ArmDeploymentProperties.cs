// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> ArmDeployment properties. </summary>
    public partial class ArmDeploymentProperties
    {
        /// <summary> Initializes a new instance of ArmDeploymentProperties. </summary>
        /// <param name="mode"> The mode that is used to deploy resources. This value can be either Incremental or Complete. In Incremental mode, resources are deployed without deleting existing resources that are not included in the template. In Complete mode, resources are deployed and existing resources in the resource group that are not included in the template are deleted. Be careful when using Complete mode as you may unintentionally delete resources. </param>
        public ArmDeploymentProperties(ArmDeploymentMode mode)
        {
            Mode = mode;
        }

        public ArmDeploymentMode Mode { get; }

        public System.BinaryData Template { get; set; }
    }
}