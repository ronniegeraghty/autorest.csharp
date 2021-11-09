// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using SupersetFlattenInheritance.Models;

namespace SupersetFlattenInheritance
{
    /// <summary> A class representing collection of ResourceModel2 and their operations over a ResourceGroup. </summary>
    public partial class ResourceModel2Collection : ArmCollection, IEnumerable<ResourceModel2>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ResourceModel2SRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceModel2Collection"/> class for mocking. </summary>
        protected ResourceModel2Collection()
        {
        }

        /// <summary> Initializes a new instance of ResourceModel2Collection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ResourceModel2Collection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ResourceModel2SRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        IEnumerator<ResourceModel2> IEnumerable<ResourceModel2>.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <param name="resourceModel2SName"> The String to use. </param>
        /// <param name="parameters"> The ResourceModel2 to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceModel2SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ResourceModel2PutOperation CreateOrUpdate(string resourceModel2SName, ResourceModel2Data parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (resourceModel2SName == null)
            {
                throw new ArgumentNullException(nameof(resourceModel2SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceModel2Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Put(Id.ResourceGroupName, resourceModel2SName, parameters, cancellationToken);
                var operation = new ResourceModel2PutOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="resourceModel2SName"> The String to use. </param>
        /// <param name="parameters"> The ResourceModel2 to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceModel2SName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ResourceModel2PutOperation> CreateOrUpdateAsync(string resourceModel2SName, ResourceModel2Data parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (resourceModel2SName == null)
            {
                throw new ArgumentNullException(nameof(resourceModel2SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceModel2Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.PutAsync(Id.ResourceGroupName, resourceModel2SName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ResourceModel2PutOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="resourceModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ResourceModel2> Get(string resourceModel2SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceModel2Collection.Get");
            scope.Start();
            try
            {
                if (resourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(resourceModel2SName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, resourceModel2SName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceModel2(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="resourceModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ResourceModel2>> GetAsync(string resourceModel2SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceModel2Collection.Get");
            scope.Start();
            try
            {
                if (resourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(resourceModel2SName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, resourceModel2SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ResourceModel2(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ResourceModel2> GetIfExists(string resourceModel2SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceModel2Collection.GetIfExists");
            scope.Start();
            try
            {
                if (resourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(resourceModel2SName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, resourceModel2SName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ResourceModel2>(null, response.GetRawResponse())
                    : Response.FromValue(new ResourceModel2(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ResourceModel2>> GetIfExistsAsync(string resourceModel2SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceModel2Collection.GetIfExists");
            scope.Start();
            try
            {
                if (resourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(resourceModel2SName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, resourceModel2SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ResourceModel2>(null, response.GetRawResponse())
                    : Response.FromValue(new ResourceModel2(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string resourceModel2SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceModel2Collection.CheckIfExists");
            scope.Start();
            try
            {
                if (resourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(resourceModel2SName));
                }

                var response = GetIfExists(resourceModel2SName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string resourceModel2SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceModel2Collection.CheckIfExists");
            scope.Start();
            try
            {
                if (resourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(resourceModel2SName));
                }

                var response = await GetIfExistsAsync(resourceModel2SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<ResourceModel2>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceModel2Collection.GetAll");
            scope.Start();
            try
            {
                var response = await _restClient.GetAllAsync(Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(data => new ResourceModel2(Parent, data)).ToArray() as IReadOnlyList<ResourceModel2>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<ResourceModel2>> GetAll(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceModel2Collection.GetAll");
            scope.Start();
            try
            {
                var response = _restClient.GetAll(Id.ResourceGroupName, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(data => new ResourceModel2(Parent, data)).ToArray() as IReadOnlyList<ResourceModel2>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ResourceModel2" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceModel2Collection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ResourceModel2.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ResourceModel2" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceModel2Collection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ResourceModel2.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, ResourceModel2, ResourceModel2Data> Construct() { }
    }
}