// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace MgmtMockTest.Models
{
    /// <summary> Properties of the managed HSM Pool. </summary>
    public partial class ManagedHsmProperties
    {
        /// <summary> Initializes a new instance of ManagedHsmProperties. </summary>
        public ManagedHsmProperties()
        {
            InitialAdminObjectIds = new ChangeTrackingList<string>();
            PrivateEndpointConnections = new ChangeTrackingList<MhsmPrivateEndpointConnectionItem>();
        }

        /// <summary> Initializes a new instance of ManagedHsmProperties. </summary>
        /// <param name="settings"> The settings that should be applied to this ManagedHsm. This should be a JSON string or JSON object. </param>
        /// <param name="protectedSettings"> The protected settings that should be applied to this ManagedHsm. This should be a JSON string or JSON object. </param>
        /// <param name="tenantId"> The Azure Active Directory tenant ID that should be used for authenticating requests to the managed HSM pool. </param>
        /// <param name="initialAdminObjectIds"> Array of initial administrators object ids for this managed hsm pool. </param>
        /// <param name="hsmUri"> The URI of the managed hsm pool for performing operations on keys. </param>
        /// <param name="enableSoftDelete"> Property to specify whether the &apos;soft delete&apos; functionality is enabled for this managed HSM pool. If it&apos;s not set to any value(true or false) when creating new managed HSM pool, it will be set to true by default. Once set to true, it cannot be reverted to false. </param>
        /// <param name="softDeleteRetentionInDays"> softDelete data retention days. It accepts &gt;=7 and &lt;=90. </param>
        /// <param name="enablePurgeProtection"> Property specifying whether protection against purge is enabled for this managed HSM pool. Setting this property to true activates protection against purge for this managed HSM pool and its content - only the Managed HSM service may initiate a hard, irrecoverable deletion. The setting is effective only if soft delete is also enabled. Enabling this functionality is irreversible. </param>
        /// <param name="createMode"> The create mode to indicate whether the resource is being created or is being recovered from a deleted resource. </param>
        /// <param name="statusMessage"> Resource Status Message. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="networkAcls"> Rules governing the accessibility of the key vault from specific network locations. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections associated with the managed hsm pool. </param>
        /// <param name="publicNetworkAccess"> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </param>
        /// <param name="scheduledPurgeOn"> The scheduled purge date in UTC. </param>
        internal ManagedHsmProperties(BinaryData settings, BinaryData protectedSettings, Guid? tenantId, IList<string> initialAdminObjectIds, Uri hsmUri, bool? enableSoftDelete, int? softDeleteRetentionInDays, bool? enablePurgeProtection, CreateMode? createMode, string statusMessage, ProvisioningState? provisioningState, MhsmNetworkRuleSet networkAcls, IReadOnlyList<MhsmPrivateEndpointConnectionItem> privateEndpointConnections, PublicNetworkAccess? publicNetworkAccess, DateTimeOffset? scheduledPurgeOn)
        {
            Settings = settings;
            ProtectedSettings = protectedSettings;
            TenantId = tenantId;
            InitialAdminObjectIds = initialAdminObjectIds;
            HsmUri = hsmUri;
            EnableSoftDelete = enableSoftDelete;
            SoftDeleteRetentionInDays = softDeleteRetentionInDays;
            EnablePurgeProtection = enablePurgeProtection;
            CreateMode = createMode;
            StatusMessage = statusMessage;
            ProvisioningState = provisioningState;
            NetworkAcls = networkAcls;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            ScheduledPurgeOn = scheduledPurgeOn;
        }

        /// <summary> The settings that should be applied to this ManagedHsm. This should be a JSON string or JSON object. </summary>
        public BinaryData Settings { get; set; }
        /// <summary> The protected settings that should be applied to this ManagedHsm. This should be a JSON string or JSON object. </summary>
        public BinaryData ProtectedSettings { get; set; }
        /// <summary> The Azure Active Directory tenant ID that should be used for authenticating requests to the managed HSM pool. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Array of initial administrators object ids for this managed hsm pool. </summary>
        public IList<string> InitialAdminObjectIds { get; }
        /// <summary> The URI of the managed hsm pool for performing operations on keys. </summary>
        public Uri HsmUri { get; }
        /// <summary> Property to specify whether the &apos;soft delete&apos; functionality is enabled for this managed HSM pool. If it&apos;s not set to any value(true or false) when creating new managed HSM pool, it will be set to true by default. Once set to true, it cannot be reverted to false. </summary>
        public bool? EnableSoftDelete { get; set; }
        /// <summary> softDelete data retention days. It accepts &gt;=7 and &lt;=90. </summary>
        public int? SoftDeleteRetentionInDays { get; set; }
        /// <summary> Property specifying whether protection against purge is enabled for this managed HSM pool. Setting this property to true activates protection against purge for this managed HSM pool and its content - only the Managed HSM service may initiate a hard, irrecoverable deletion. The setting is effective only if soft delete is also enabled. Enabling this functionality is irreversible. </summary>
        public bool? EnablePurgeProtection { get; set; }
        /// <summary> The create mode to indicate whether the resource is being created or is being recovered from a deleted resource. </summary>
        public CreateMode? CreateMode { get; set; }
        /// <summary> Resource Status Message. </summary>
        public string StatusMessage { get; }
        /// <summary> Provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Rules governing the accessibility of the key vault from specific network locations. </summary>
        public MhsmNetworkRuleSet NetworkAcls { get; set; }
        /// <summary> List of private endpoint connections associated with the managed hsm pool. </summary>
        public IReadOnlyList<MhsmPrivateEndpointConnectionItem> PrivateEndpointConnections { get; }
        /// <summary> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The scheduled purge date in UTC. </summary>
        public DateTimeOffset? ScheduledPurgeOn { get; }
    }
}
