// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace Object_Type
{
    /// <summary> The ObjectType service client. </summary>
    public partial class ObjectTypeClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ObjectTypeRestClient RestClient { get; }

        /// <summary> Initializes a new instance of ObjectTypeClient for mocking. </summary>
        protected ObjectTypeClient()
        {
        }

        /// <summary> Initializes a new instance of ObjectTypeClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ObjectTypeClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new ObjectTypeRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Basic get that returns an object. Returns object { &apos;message&apos;: &apos;An object was successfully returned&apos; }. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ObjectTypeClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Basic get that returns an object. Returns object { &apos;message&apos;: &apos;An object was successfully returned&apos; }. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ObjectTypeClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Basic put that puts an object. Pass in {&apos;foo&apos;: &apos;bar&apos;} to get a 200 and anything else to get an object error. </summary>
        /// <param name="putObject"> Pass in {&apos;foo&apos;: &apos;bar&apos;} for a 200, anything else for an object error. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutAsync(object putObject, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ObjectTypeClient.Put");
            scope.Start();
            try
            {
                return await RestClient.PutAsync(putObject, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Basic put that puts an object. Pass in {&apos;foo&apos;: &apos;bar&apos;} to get a 200 and anything else to get an object error. </summary>
        /// <param name="putObject"> Pass in {&apos;foo&apos;: &apos;bar&apos;} for a 200, anything else for an object error. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Put(object putObject, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ObjectTypeClient.Put");
            scope.Start();
            try
            {
                return RestClient.Put(putObject, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
