
#nullable enable

namespace Vercel
{
    public partial class DeploymentsClient
    {
        partial void PrepareGetDeploymentEventsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string idOrUrl,
            ref global::Vercel.GetDeploymentEventsDirection? direction,
            ref double? follow,
            ref double? limit,
            ref string? name,
            ref double? since,
            ref double? until,
            ref global::Vercel.OneOf<double?, string>? statusCode,
            ref double? delimiter,
            ref double? builds,
            ref string? teamId,
            ref string? slug);
        partial void PrepareGetDeploymentEventsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string idOrUrl,
            global::Vercel.GetDeploymentEventsDirection? direction,
            double? follow,
            double? limit,
            string? name,
            double? since,
            double? until,
            global::Vercel.OneOf<double?, string>? statusCode,
            double? delimiter,
            double? builds,
            string? teamId,
            string? slug);
        partial void ProcessGetDeploymentEventsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDeploymentEventsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get deployment events<br/>
        /// Get the build logs of a deployment by deployment ID and build ID. It can work as an infinite stream of logs or as a JSON endpoint depending on the input parameters.
        /// </summary>
        /// <param name="idOrUrl">
        /// The unique identifier or hostname of the deployment.<br/>
        /// Example: dpl_5WJWYSyB7BpgTj3EuwF37WMRBXBtPQ2iTMJHJBJyRfd
        /// </param>
        /// <param name="direction">
        /// Order of the returned events based on the timestamp.<br/>
        /// Default Value: forward<br/>
        /// Example: backward
        /// </param>
        /// <param name="follow">
        /// When enabled, this endpoint will return live events as they happen.<br/>
        /// Example: 1
        /// </param>
        /// <param name="limit">
        /// Maximum number of events to return. Provide `-1` to return all available logs.<br/>
        /// Example: 100
        /// </param>
        /// <param name="name">
        /// Deployment build ID.<br/>
        /// Example: bld_cotnkcr76
        /// </param>
        /// <param name="since">
        /// Timestamp for when build logs should be pulled from.<br/>
        /// Example: 1540095775941L
        /// </param>
        /// <param name="until">
        /// Timestamp for when the build logs should be pulled up until.<br/>
        /// Example: 1540106318643L
        /// </param>
        /// <param name="statusCode">
        /// HTTP status code range to filter events by.<br/>
        /// Example: 5xx
        /// </param>
        /// <param name="delimiter">
        /// Example: 1
        /// </param>
        /// <param name="builds">
        /// Example: 1
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetDeploymentEventsResponseItemVariant1, global::Vercel.GetDeploymentEventsResponseItemVariant2>>> GetDeploymentEventsAsync(
            string idOrUrl,
            global::Vercel.GetDeploymentEventsDirection? direction = default,
            double? follow = default,
            double? limit = default,
            string? name = default,
            double? since = default,
            double? until = default,
            global::Vercel.OneOf<double?, string>? statusCode = default,
            double? delimiter = default,
            double? builds = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetDeploymentEventsArguments(
                httpClient: HttpClient,
                idOrUrl: ref idOrUrl,
                direction: ref direction,
                follow: ref follow,
                limit: ref limit,
                name: ref name,
                since: ref since,
                until: ref until,
                statusCode: ref statusCode,
                delimiter: ref delimiter,
                builds: ref builds,
                teamId: ref teamId,
                slug: ref slug);

            var __pathBuilder = new global::Vercel.PathBuilder(
                path: $"/v3/deployments/{idOrUrl}/events",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("direction", direction?.ToValueString())
                .AddOptionalParameter("follow", follow?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("since", since?.ToString())
                .AddOptionalParameter("until", until?.ToString())
                .AddOptionalParameter("statusCode", statusCode?.ToString())
                .AddOptionalParameter("delimiter", delimiter?.ToString())
                .AddOptionalParameter("builds", builds?.ToString())
                .AddOptionalParameter("teamId", teamId)
                .AddOptionalParameter("slug", slug) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetDeploymentEventsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                idOrUrl: idOrUrl,
                direction: direction,
                follow: follow,
                limit: limit,
                name: name,
                since: since,
                until: until,
                statusCode: statusCode,
                delimiter: delimiter,
                builds: builds,
                teamId: teamId,
                slug: slug);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetDeploymentEventsResponse(
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
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::Vercel.ApiException(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
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
                ProcessGetDeploymentEventsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        (global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetDeploymentEventsResponseItemVariant1, global::Vercel.GetDeploymentEventsResponseItemVariant2>>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetDeploymentEventsResponseItemVariant1, global::Vercel.GetDeploymentEventsResponseItemVariant2>>), JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        (global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetDeploymentEventsResponseItemVariant1, global::Vercel.GetDeploymentEventsResponseItemVariant2>>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetDeploymentEventsResponseItemVariant1, global::Vercel.GetDeploymentEventsResponseItemVariant2>>), JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
    }
}