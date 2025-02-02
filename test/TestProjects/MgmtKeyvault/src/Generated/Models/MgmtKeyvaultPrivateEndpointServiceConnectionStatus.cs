// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MgmtKeyvault.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct MgmtKeyvaultPrivateEndpointServiceConnectionStatus : IEquatable<MgmtKeyvaultPrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MgmtKeyvaultPrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MgmtKeyvaultPrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Pending. </summary>
        public static MgmtKeyvaultPrivateEndpointServiceConnectionStatus Pending { get; } = new MgmtKeyvaultPrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static MgmtKeyvaultPrivateEndpointServiceConnectionStatus Approved { get; } = new MgmtKeyvaultPrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static MgmtKeyvaultPrivateEndpointServiceConnectionStatus Rejected { get; } = new MgmtKeyvaultPrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static MgmtKeyvaultPrivateEndpointServiceConnectionStatus Disconnected { get; } = new MgmtKeyvaultPrivateEndpointServiceConnectionStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="MgmtKeyvaultPrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(MgmtKeyvaultPrivateEndpointServiceConnectionStatus left, MgmtKeyvaultPrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MgmtKeyvaultPrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(MgmtKeyvaultPrivateEndpointServiceConnectionStatus left, MgmtKeyvaultPrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MgmtKeyvaultPrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator MgmtKeyvaultPrivateEndpointServiceConnectionStatus(string value) => new MgmtKeyvaultPrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MgmtKeyvaultPrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MgmtKeyvaultPrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
