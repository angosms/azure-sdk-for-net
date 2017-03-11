// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol
{
    using System.Linq;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// AccountOperations operations.
    /// </summary>
    internal partial class AccountOperations : Microsoft.Rest.IServiceOperations<BatchServiceClient>, IAccountOperations
    {
        /// <summary>
        /// Initializes a new instance of the AccountOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        internal AccountOperations(BatchServiceClient client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            this.Client = client;
        }

        /// <summary>
        /// Gets a reference to the BatchServiceClient
        /// </summary>
        public BatchServiceClient Client { get; private set; }

        /// <summary>
        /// Lists all node agent SKUs supported by the Azure Batch service.
        /// </summary>
        /// <param name='accountListNodeAgentSkusOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<NodeAgentSku>,AccountListNodeAgentSkusHeaders>> ListNodeAgentSkusWithHttpMessagesAsync(AccountListNodeAgentSkusOptions accountListNodeAgentSkusOptions = default(AccountListNodeAgentSkusOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            if (this.Client.ApiVersion == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "this.Client.ApiVersion");
            }
            string filter = default(string);
            if (accountListNodeAgentSkusOptions != null)
            {
                filter = accountListNodeAgentSkusOptions.Filter;
            }
            int? maxResults = default(int?);
            if (accountListNodeAgentSkusOptions != null)
            {
                maxResults = accountListNodeAgentSkusOptions.MaxResults;
            }
            int? timeout = default(int?);
            if (accountListNodeAgentSkusOptions != null)
            {
                timeout = accountListNodeAgentSkusOptions.Timeout;
            }
            System.Guid? clientRequestId = default(System.Guid?);
            if (accountListNodeAgentSkusOptions != null)
            {
                clientRequestId = accountListNodeAgentSkusOptions.ClientRequestId;
            }
            bool? returnClientRequestId = default(bool?);
            if (accountListNodeAgentSkusOptions != null)
            {
                returnClientRequestId = accountListNodeAgentSkusOptions.ReturnClientRequestId;
            }
            System.DateTime? ocpDate = default(System.DateTime?);
            if (accountListNodeAgentSkusOptions != null)
            {
                ocpDate = accountListNodeAgentSkusOptions.OcpDate;
            }
            // Tracing
            bool _shouldTrace = Microsoft.Rest.ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = Microsoft.Rest.ServiceClientTracing.NextInvocationId.ToString();
                System.Collections.Generic.Dictionary<string, object> tracingParameters = new System.Collections.Generic.Dictionary<string, object>();
                tracingParameters.Add("filter", filter);
                tracingParameters.Add("maxResults", maxResults);
                tracingParameters.Add("timeout", timeout);
                tracingParameters.Add("clientRequestId", clientRequestId);
                tracingParameters.Add("returnClientRequestId", returnClientRequestId);
                tracingParameters.Add("ocpDate", ocpDate);
                tracingParameters.Add("cancellationToken", cancellationToken);
                Microsoft.Rest.ServiceClientTracing.Enter(_invocationId, this, "ListNodeAgentSkus", tracingParameters);
            }
            // Construct URL
            var _baseUrl = this.Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "nodeagentskus").ToString();
            System.Collections.Generic.List<string> _queryParameters = new System.Collections.Generic.List<string>();
            if (this.Client.ApiVersion != null)
            {
                _queryParameters.Add(string.Format("api-version={0}", System.Uri.EscapeDataString(this.Client.ApiVersion)));
            }
            if (filter != null)
            {
                _queryParameters.Add(string.Format("$filter={0}", System.Uri.EscapeDataString(filter)));
            }
            if (maxResults != null)
            {
                _queryParameters.Add(string.Format("maxresults={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(maxResults, this.Client.SerializationSettings).Trim('"'))));
            }
            if (timeout != null)
            {
                _queryParameters.Add(string.Format("timeout={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(timeout, this.Client.SerializationSettings).Trim('"'))));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new System.Net.Http.HttpRequestMessage();
            System.Net.Http.HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new System.Net.Http.HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (this.Client.GenerateClientRequestId != null && this.Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("client-request-id", System.Guid.NewGuid().ToString());
            }
            if (this.Client.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", this.Client.AcceptLanguage);
            }
            if (clientRequestId != null)
            {
                if (_httpRequest.Headers.Contains("client-request-id"))
                {
                    _httpRequest.Headers.Remove("client-request-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("client-request-id", Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(clientRequestId, this.Client.SerializationSettings).Trim('"'));
            }
            if (returnClientRequestId != null)
            {
                if (_httpRequest.Headers.Contains("return-client-request-id"))
                {
                    _httpRequest.Headers.Remove("return-client-request-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("return-client-request-id", Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(returnClientRequestId, this.Client.SerializationSettings).Trim('"'));
            }
            if (ocpDate != null)
            {
                if (_httpRequest.Headers.Contains("ocp-date"))
                {
                    _httpRequest.Headers.Remove("ocp-date");
                }
                _httpRequest.Headers.TryAddWithoutValidation("ocp-date", Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(ocpDate, new Microsoft.Rest.Serialization.DateTimeRfc1123JsonConverter()).Trim('"'));
            }


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (this.Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await this.Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            System.Net.HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new BatchErrorException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    BatchError _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<BatchError>(_responseContent, this.Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (Newtonsoft.Json.JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new Microsoft.Rest.HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new Microsoft.Rest.HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    Microsoft.Rest.ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<NodeAgentSku>,AccountListNodeAgentSkusHeaders>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("request-id").FirstOrDefault();
            }
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Page<NodeAgentSku>>(_responseContent, this.Client.DeserializationSettings);
                }
                catch (Newtonsoft.Json.JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new Microsoft.Rest.SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            try
            {
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<AccountListNodeAgentSkusHeaders>(Newtonsoft.Json.JsonSerializer.Create(this.Client.DeserializationSettings));
            }
            catch (Newtonsoft.Json.JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new Microsoft.Rest.SerializationException("Unable to deserialize the headers.", _httpResponse.GetHeadersAsJson().ToString(), ex);
            }
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// Lists all node agent SKUs supported by the Azure Batch service.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='accountListNodeAgentSkusNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<NodeAgentSku>,AccountListNodeAgentSkusHeaders>> ListNodeAgentSkusNextWithHttpMessagesAsync(string nextPageLink, AccountListNodeAgentSkusNextOptions accountListNodeAgentSkusNextOptions = default(AccountListNodeAgentSkusNextOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            if (nextPageLink == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "nextPageLink");
            }
            System.Guid? clientRequestId = default(System.Guid?);
            if (accountListNodeAgentSkusNextOptions != null)
            {
                clientRequestId = accountListNodeAgentSkusNextOptions.ClientRequestId;
            }
            bool? returnClientRequestId = default(bool?);
            if (accountListNodeAgentSkusNextOptions != null)
            {
                returnClientRequestId = accountListNodeAgentSkusNextOptions.ReturnClientRequestId;
            }
            System.DateTime? ocpDate = default(System.DateTime?);
            if (accountListNodeAgentSkusNextOptions != null)
            {
                ocpDate = accountListNodeAgentSkusNextOptions.OcpDate;
            }
            // Tracing
            bool _shouldTrace = Microsoft.Rest.ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = Microsoft.Rest.ServiceClientTracing.NextInvocationId.ToString();
                System.Collections.Generic.Dictionary<string, object> tracingParameters = new System.Collections.Generic.Dictionary<string, object>();
                tracingParameters.Add("nextPageLink", nextPageLink);
                tracingParameters.Add("clientRequestId", clientRequestId);
                tracingParameters.Add("returnClientRequestId", returnClientRequestId);
                tracingParameters.Add("ocpDate", ocpDate);
                tracingParameters.Add("cancellationToken", cancellationToken);
                Microsoft.Rest.ServiceClientTracing.Enter(_invocationId, this, "ListNodeAgentSkusNext", tracingParameters);
            }
            // Construct URL
            string _url = "{nextLink}";
            _url = _url.Replace("{nextLink}", nextPageLink);
            System.Collections.Generic.List<string> _queryParameters = new System.Collections.Generic.List<string>();
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new System.Net.Http.HttpRequestMessage();
            System.Net.Http.HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new System.Net.Http.HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (this.Client.GenerateClientRequestId != null && this.Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("client-request-id", System.Guid.NewGuid().ToString());
            }
            if (this.Client.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", this.Client.AcceptLanguage);
            }
            if (clientRequestId != null)
            {
                if (_httpRequest.Headers.Contains("client-request-id"))
                {
                    _httpRequest.Headers.Remove("client-request-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("client-request-id", Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(clientRequestId, this.Client.SerializationSettings).Trim('"'));
            }
            if (returnClientRequestId != null)
            {
                if (_httpRequest.Headers.Contains("return-client-request-id"))
                {
                    _httpRequest.Headers.Remove("return-client-request-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("return-client-request-id", Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(returnClientRequestId, this.Client.SerializationSettings).Trim('"'));
            }
            if (ocpDate != null)
            {
                if (_httpRequest.Headers.Contains("ocp-date"))
                {
                    _httpRequest.Headers.Remove("ocp-date");
                }
                _httpRequest.Headers.TryAddWithoutValidation("ocp-date", Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(ocpDate, new Microsoft.Rest.Serialization.DateTimeRfc1123JsonConverter()).Trim('"'));
            }


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (this.Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await this.Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            System.Net.HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new BatchErrorException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    BatchError _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<BatchError>(_responseContent, this.Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (Newtonsoft.Json.JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new Microsoft.Rest.HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new Microsoft.Rest.HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    Microsoft.Rest.ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<NodeAgentSku>,AccountListNodeAgentSkusHeaders>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("request-id").FirstOrDefault();
            }
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Page<NodeAgentSku>>(_responseContent, this.Client.DeserializationSettings);
                }
                catch (Newtonsoft.Json.JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new Microsoft.Rest.SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            try
            {
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<AccountListNodeAgentSkusHeaders>(Newtonsoft.Json.JsonSerializer.Create(this.Client.DeserializationSettings));
            }
            catch (Newtonsoft.Json.JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new Microsoft.Rest.SerializationException("Unable to deserialize the headers.", _httpResponse.GetHeadersAsJson().ToString(), ex);
            }
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
