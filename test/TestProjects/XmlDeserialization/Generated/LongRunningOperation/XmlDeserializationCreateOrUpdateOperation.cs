// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using XmlDeserialization;

namespace XmlDeserialization.Models
{
    /// <summary> Creates or Updates a Xml. </summary>
    public partial class XmlDeserializationCreateOrUpdateOperation : Operation<XmlInstance>
    {
        private readonly OperationOrResponseInternals<XmlInstance> _operation;

        /// <summary> Initializes a new instance of XmlDeserializationCreateOrUpdateOperation for mocking. </summary>
        protected XmlDeserializationCreateOrUpdateOperation()
        {
        }

        internal XmlDeserializationCreateOrUpdateOperation(ArmResource operationsBase, Response<XmlInstanceData> response)
        {
            _operation = new OperationOrResponseInternals<XmlInstance>(Response.FromValue(new XmlInstance(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override XmlInstance Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<XmlInstance>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<XmlInstance>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}