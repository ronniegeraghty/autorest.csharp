// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MgmtSignalR.Models
{
    /// <summary> Gets or sets the type of auth. None or ManagedIdentity is supported now. </summary>
    public readonly partial struct UpstreamAuthType : IEquatable<UpstreamAuthType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UpstreamAuthType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UpstreamAuthType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string ManagedIdentityValue = "ManagedIdentity";

        /// <summary> None. </summary>
        public static UpstreamAuthType None { get; } = new UpstreamAuthType(NoneValue);
        /// <summary> ManagedIdentity. </summary>
        public static UpstreamAuthType ManagedIdentity { get; } = new UpstreamAuthType(ManagedIdentityValue);
        /// <summary> Determines if two <see cref="UpstreamAuthType"/> values are the same. </summary>
        public static bool operator ==(UpstreamAuthType left, UpstreamAuthType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UpstreamAuthType"/> values are not the same. </summary>
        public static bool operator !=(UpstreamAuthType left, UpstreamAuthType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UpstreamAuthType"/>. </summary>
        public static implicit operator UpstreamAuthType(string value) => new UpstreamAuthType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UpstreamAuthType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UpstreamAuthType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}