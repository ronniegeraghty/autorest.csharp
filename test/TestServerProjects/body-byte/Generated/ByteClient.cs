// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace body_byte
{
    /// <summary> The Byte service client. </summary>
    public partial class ByteClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ByteRestClient RestClient { get; }

        /// <summary> Initializes a new instance of ByteClient for mocking. </summary>
        protected ByteClient()
        {
        }

        /// <summary> Initializes a new instance of ByteClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal ByteClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new ByteRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get null byte value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<byte[]>> GetNullAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ByteClient.GetNull");
            scope.Start();
            try
            {
                return await RestClient.GetNullAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get null byte value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<byte[]> GetNull(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ByteClient.GetNull");
            scope.Start();
            try
            {
                return RestClient.GetNull(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get empty byte value &apos;&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<byte[]>> GetEmptyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ByteClient.GetEmpty");
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

        /// <summary> Get empty byte value &apos;&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<byte[]> GetEmpty(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ByteClient.GetEmpty");
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

        /// <summary> Get non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<byte[]>> GetNonAsciiAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ByteClient.GetNonAscii");
            scope.Start();
            try
            {
                return await RestClient.GetNonAsciiAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<byte[]> GetNonAscii(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ByteClient.GetNonAscii");
            scope.Start();
            try
            {
                return RestClient.GetNonAscii(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6). </summary>
        /// <param name="byteBody"> Base64-encoded non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutNonAsciiAsync(string byteBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ByteClient.PutNonAscii");
            scope.Start();
            try
            {
                return await RestClient.PutNonAsciiAsync(byteBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6). </summary>
        /// <param name="byteBody"> Base64-encoded non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutNonAscii(string byteBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ByteClient.PutNonAscii");
            scope.Start();
            try
            {
                return RestClient.PutNonAscii(byteBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get invalid byte value &apos;:::SWAGGER::::&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<byte[]>> GetInvalidAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ByteClient.GetInvalid");
            scope.Start();
            try
            {
                return await RestClient.GetInvalidAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get invalid byte value &apos;:::SWAGGER::::&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<byte[]> GetInvalid(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ByteClient.GetInvalid");
            scope.Start();
            try
            {
                return RestClient.GetInvalid(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
