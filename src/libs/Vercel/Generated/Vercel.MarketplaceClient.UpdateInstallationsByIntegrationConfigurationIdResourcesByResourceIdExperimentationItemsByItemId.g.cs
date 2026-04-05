
#nullable enable

namespace Vercel
{
    public partial class MarketplaceClient
    {
        partial void PrepareUpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string integrationConfigurationId,
            ref string resourceId,
            ref string itemId,
            global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequest request);
        partial void PrepareUpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string integrationConfigurationId,
            string resourceId,
            string itemId,
            global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequest request);
        partial void ProcessUpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Patch an existing experimentation item<br/>
        /// Patch an existing experimentation item
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        public async global::System.Threading.Tasks.Task UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdAsync(
            string integrationConfigurationId,
            string resourceId,
            string itemId,

            global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdArguments(
                httpClient: HttpClient,
                integrationConfigurationId: ref integrationConfigurationId,
                resourceId: ref resourceId,
                itemId: ref itemId,
                request: request);

            var __pathBuilder = new global::Vercel.PathBuilder(
                path: $"/v1/installations/{integrationConfigurationId}/resources/{resourceId}/experimentation/items/{itemId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                integrationConfigurationId: integrationConfigurationId,
                resourceId: resourceId,
                itemId: itemId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Vercel.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::Vercel.ApiException(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::Vercel.ApiException(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::Vercel.ApiException(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Vercel.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Vercel.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Patch an existing experimentation item<br/>
        /// Patch an existing experimentation item
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="itemId"></param>
        /// <param name="slug"></param>
        /// <param name="origin"></param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="description"></param>
        /// <param name="isArchived"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdAsync(
            string integrationConfigurationId,
            string resourceId,
            string itemId,
            string slug,
            string origin,
            string? name = default,
            global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory? category = default,
            string? description = default,
            bool? isArchived = default,
            double? createdAt = default,
            double? updatedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequest
            {
                Slug = slug,
                Origin = origin,
                Name = name,
                Category = category,
                Description = description,
                IsArchived = isArchived,
                CreatedAt = createdAt,
                UpdatedAt = updatedAt,
            };

            await UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdAsync(
                integrationConfigurationId: integrationConfigurationId,
                resourceId: resourceId,
                itemId: itemId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}