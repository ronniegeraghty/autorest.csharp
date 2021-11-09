// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace CollapseRequestConditions
{
    /// <summary> The RequestCondtionCollapse service client. </summary>
    public partial class RequestCondtionCollapseClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;

        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get => _pipeline; }

        /// <summary> Initializes a new instance of RequestCondtionCollapseClient for mocking. </summary>
        protected RequestCondtionCollapseClient()
        {
        }

        /// <summary> Initializes a new instance of RequestCondtionCollapseClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public RequestCondtionCollapseClient(AzureKeyCredential credential, Uri endpoint = null, CollapseRequestConditionsClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("http://localhost:3000");

            options ??= new CollapseRequestConditionsClientOptions();

            _clientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <param name="requestConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CollapsePUTAsync(RequestConditions requestConditions, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RequestCondtionCollapseClient.CollapsePUT");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCollapsePUTRequest(requestConditions, content);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="requestConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response CollapsePUT(RequestConditions requestConditions, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RequestCondtionCollapseClient.CollapsePUT");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCollapsePUTRequest(requestConditions, content);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="requestConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CollapseGetAsync(RequestConditions requestConditions, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RequestCondtionCollapseClient.CollapseGet");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCollapseGetRequest(requestConditions);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="requestConditions"> The content to send as the request conditions of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response CollapseGet(RequestConditions requestConditions, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RequestCondtionCollapseClient.CollapseGet");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCollapseGetRequest(requestConditions);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCollapsePUTRequest(RequestConditions requestConditions, RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/RequestCondtionCollapse/", false);
            request.Uri = uri;
            if (requestConditions != null)
            {
                using ETag ifMatch = requestConditions.IfMatch;
                if (ifMatch != null)
                {
                    request.Headers.Add("If-Match", ifMatch);
                }
                using ETag ifNoneMatch = requestConditions.IfNoneMatch;
                if (ifNoneMatch != null)
                {
                    request.Headers.Add("If-None-Match", ifNoneMatch);
                }
                using DateTimeOffset ifModifiedSince = requestConditions.IfModifiedSince;
                if (ifModifiedSince != null)
                {
                    request.Headers.Add("If-Modified-Since", ifModifiedSince.Value, "R");
                }
                using DateTimeOffset ifUnmodifiedSince = requestConditions.IfUnmodifiedSince;
                if (ifUnmodifiedSince != null)
                {
                    request.Headers.Add("If-Unmodified-Since", ifUnmodifiedSince.Value, "R");
                }
            }
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateCollapseGetRequest(RequestConditions requestConditions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/RequestCondtionCollapse/", false);
            request.Uri = uri;
            if (requestConditions != null)
            {
                using ETag ifMatch = requestConditions.IfMatch;
                if (ifMatch != null)
                {
                    request.Headers.Add("If-Match", ifMatch);
                }
                using ETag ifNoneMatch = requestConditions.IfNoneMatch;
                if (ifNoneMatch != null)
                {
                    request.Headers.Add("If-None-Match", ifNoneMatch);
                }
                using DateTimeOffset ifModifiedSince = requestConditions.IfModifiedSince;
                if (ifModifiedSince != null)
                {
                    request.Headers.Add("If-Modified-Since", ifModifiedSince.Value, "R");
                }
                using DateTimeOffset ifUnmodifiedSince = requestConditions.IfUnmodifiedSince;
                if (ifUnmodifiedSince != null)
                {
                    request.Headers.Add("If-Unmodified-Since", ifUnmodifiedSince.Value, "R");
                }
            }
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
    }
}