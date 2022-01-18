// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region PolicyAssignment
        /// <summary> Gets an object representing a PolicyAssignmentCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="PolicyAssignmentCollection" /> object. </returns>
        public static PolicyAssignmentCollection GetPolicyAssignments(this ResourceGroup resourceGroup)
        {
            return new PolicyAssignmentCollection(resourceGroup);
        }
        #endregion

        #region PolicyExemption
        /// <summary> Gets an object representing a PolicyExemptionCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="PolicyExemptionCollection" /> object. </returns>
        public static PolicyExemptionCollection GetPolicyExemptions(this ResourceGroup resourceGroup)
        {
            return new PolicyExemptionCollection(resourceGroup);
        }
        #endregion

        #region ManagementLockObject
        /// <summary> Gets an object representing a ManagementLockObjectCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ManagementLockObjectCollection" /> object. </returns>
        public static ManagementLockObjectCollection GetManagementLockObjects(this ResourceGroup resourceGroup)
        {
            return new ManagementLockObjectCollection(resourceGroup);
        }
        #endregion
    }
}