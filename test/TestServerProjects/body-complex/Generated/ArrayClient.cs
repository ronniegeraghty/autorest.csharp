// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Body_Complex.Models;

namespace Body_Complex
{
    /// <summary> The Array service client. </summary>
    public partial class ArrayClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ArrayRestClient RestClient { get; }

        /// <summary> Initializes a new instance of ArrayClient for mocking. </summary>
        protected ArrayClient()
        {
        }

        /// <summary> Initializes a new instance of ArrayClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ArrayClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new ArrayRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get complex types with array property. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ArrayWrapper>> GetValidAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.GetValid");
            scope.Start();
            try
            {
                return await RestClient.GetValidAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types with array property. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ArrayWrapper> GetValid(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.GetValid");
            scope.Start();
            try
            {
                return RestClient.GetValid(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types with array property. </summary>
        /// <param name="complexBody"> Please put an array with 4 items: &quot;1, 2, 3, 4&quot;, &quot;&quot;, null, &quot;&amp;S#$(*Y&quot;, &quot;The quick brown fox jumps over the lazy dog&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutValidAsync(ArrayWrapper complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.PutValid");
            scope.Start();
            try
            {
                return await RestClient.PutValidAsync(complexBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types with array property. </summary>
        /// <param name="complexBody"> Please put an array with 4 items: &quot;1, 2, 3, 4&quot;, &quot;&quot;, null, &quot;&amp;S#$(*Y&quot;, &quot;The quick brown fox jumps over the lazy dog&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutValid(ArrayWrapper complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.PutValid");
            scope.Start();
            try
            {
                return RestClient.PutValid(complexBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types with array property which is empty. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ArrayWrapper>> GetEmptyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.GetEmpty");
            scope.Start();
            try
            {
                return await RestClient.GetEmptyAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types with array property which is empty. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ArrayWrapper> GetEmpty(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.GetEmpty");
            scope.Start();
            try
            {
                return RestClient.GetEmpty(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types with array property which is empty. </summary>
        /// <param name="complexBody"> Please put an empty array. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutEmptyAsync(ArrayWrapper complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.PutEmpty");
            scope.Start();
            try
            {
                return await RestClient.PutEmptyAsync(complexBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types with array property which is empty. </summary>
        /// <param name="complexBody"> Please put an empty array. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutEmpty(ArrayWrapper complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.PutEmpty");
            scope.Start();
            try
            {
                return RestClient.PutEmpty(complexBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types with array property while server doesn&apos;t provide a response payload. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ArrayWrapper>> GetNotProvidedAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.GetNotProvided");
            scope.Start();
            try
            {
                return await RestClient.GetNotProvidedAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types with array property while server doesn&apos;t provide a response payload. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ArrayWrapper> GetNotProvided(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ArrayClient.GetNotProvided");
            scope.Start();
            try
            {
                return RestClient.GetNotProvided(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
