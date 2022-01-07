// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace Url_Multi_CollectionFormat
{
    /// <summary> The Queries service client. </summary>
    public partial class QueriesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal QueriesRestClient RestClient { get; }

        /// <summary> Initializes a new instance of QueriesClient for mocking. </summary>
        protected QueriesClient()
        {
        }

        /// <summary> Initializes a new instance of QueriesClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal QueriesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new QueriesRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get a null array of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> a null array of string using the multi-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ArrayStringMultiNullAsync(IEnumerable<string> arrayQuery = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueriesClient.ArrayStringMultiNull");
            scope.Start();
            try
            {
                return await RestClient.ArrayStringMultiNullAsync(arrayQuery, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a null array of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> a null array of string using the multi-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ArrayStringMultiNull(IEnumerable<string> arrayQuery = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueriesClient.ArrayStringMultiNull");
            scope.Start();
            try
            {
                return RestClient.ArrayStringMultiNull(arrayQuery, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an empty array [] of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> an empty array [] of string using the multi-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ArrayStringMultiEmptyAsync(IEnumerable<string> arrayQuery = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueriesClient.ArrayStringMultiEmpty");
            scope.Start();
            try
            {
                return await RestClient.ArrayStringMultiEmptyAsync(arrayQuery, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an empty array [] of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> an empty array [] of string using the multi-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ArrayStringMultiEmpty(IEnumerable<string> arrayQuery = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueriesClient.ArrayStringMultiEmpty");
            scope.Start();
            try
            {
                return RestClient.ArrayStringMultiEmpty(arrayQuery, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an array of string [&apos;ArrayQuery1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the mult-array format. </summary>
        /// <param name="arrayQuery"> an array of string [&apos;ArrayQuery1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the mult-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ArrayStringMultiValidAsync(IEnumerable<string> arrayQuery = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueriesClient.ArrayStringMultiValid");
            scope.Start();
            try
            {
                return await RestClient.ArrayStringMultiValidAsync(arrayQuery, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an array of string [&apos;ArrayQuery1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the mult-array format. </summary>
        /// <param name="arrayQuery"> an array of string [&apos;ArrayQuery1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the mult-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ArrayStringMultiValid(IEnumerable<string> arrayQuery = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueriesClient.ArrayStringMultiValid");
            scope.Start();
            try
            {
                return RestClient.ArrayStringMultiValid(arrayQuery, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
