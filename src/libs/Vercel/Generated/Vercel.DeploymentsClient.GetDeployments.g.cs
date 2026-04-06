
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel
{
    public partial class DeploymentsClient
    {
        partial void PrepareGetDeploymentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? app,
            ref double? from,
            ref double? limit,
            ref string? projectId,
            global::System.Collections.Generic.IList<string>? projectIds,
            ref string? target,
            ref double? to,
            ref string? users,
            ref double? since,
            ref double? until,
            ref string? state,
            ref bool? rollbackCandidate,
            ref string? branch,
            ref string? sha,
            ref string? teamId,
            ref string? slug);
        partial void PrepareGetDeploymentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? app,
            double? from,
            double? limit,
            string? projectId,
            global::System.Collections.Generic.IList<string>? projectIds,
            string? target,
            double? to,
            string? users,
            double? since,
            double? until,
            string? state,
            bool? rollbackCandidate,
            string? branch,
            string? sha,
            string? teamId,
            string? slug);
        partial void ProcessGetDeploymentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDeploymentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List deployments<br/>
        /// List deployments under the authenticated user or team. If a deployment hasn't finished uploading (is incomplete), the `url` property will have a value of `null`.
        /// </summary>
        /// <param name="app">
        /// Name of the deployment.<br/>
        /// Example: docs
        /// </param>
        /// <param name="from">
        /// Gets the deployment created after this Date timestamp. (default: current time)<br/>
        /// Example: 1612948664566L
        /// </param>
        /// <param name="limit">
        /// Maximum number of deployments to list from a request.<br/>
        /// Example: 10
        /// </param>
        /// <param name="projectId">
        /// Filter deployments from the given ID or name.<br/>
        /// Example: QmXGTs7mvAMMC7WW5ebrM33qKG32QK3h4vmQMjmY
        /// </param>
        /// <param name="projectIds">
        /// Filter deployments from the given project IDs. Cannot be used when projectId is specified.<br/>
        /// Example: [prj_123, prj_456]
        /// </param>
        /// <param name="target">
        /// Filter deployments based on the environment.<br/>
        /// Example: production
        /// </param>
        /// <param name="to">
        /// Gets the deployment created before this Date timestamp. (default: current time)<br/>
        /// Example: 1612948664566L
        /// </param>
        /// <param name="users">
        /// Filter out deployments based on users who have created the deployment.<br/>
        /// Example: kr1PsOIzqEL5Xg6M4VZcZosf,K4amb7K9dAt5R2vBJWF32bmY
        /// </param>
        /// <param name="since">
        /// Get Deployments created after this JavaScript timestamp.<br/>
        /// Example: 1540095775941L
        /// </param>
        /// <param name="until">
        /// Get Deployments created before this JavaScript timestamp.<br/>
        /// Example: 1540095775951L
        /// </param>
        /// <param name="state">
        /// Filter deployments based on their state (`BUILDING`, `ERROR`, `INITIALIZING`, `QUEUED`, `READY`, `CANCELED`)<br/>
        /// Example: BUILDING,READY
        /// </param>
        /// <param name="rollbackCandidate">
        /// Filter deployments based on their rollback candidacy
        /// </param>
        /// <param name="branch">
        /// Filter deployments based on the branch name
        /// </param>
        /// <param name="sha">
        /// Filter deployments based on the SHA
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vercel.GetDeploymentsResponse> GetDeploymentsAsync(
            string? app = default,
            double? from = default,
            double? limit = default,
            string? projectId = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            string? target = default,
            double? to = default,
            string? users = default,
            double? since = default,
            double? until = default,
            string? state = default,
            bool? rollbackCandidate = default,
            string? branch = default,
            string? sha = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetDeploymentsArguments(
                httpClient: HttpClient,
                app: ref app,
                from: ref from,
                limit: ref limit,
                projectId: ref projectId,
                projectIds: projectIds,
                target: ref target,
                to: ref to,
                users: ref users,
                since: ref since,
                until: ref until,
                state: ref state,
                rollbackCandidate: ref rollbackCandidate,
                branch: ref branch,
                sha: ref sha,
                teamId: ref teamId,
                slug: ref slug);

            var __pathBuilder = new global::Vercel.PathBuilder(
                path: "/v6/deployments",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("app", app)
                .AddOptionalParameter("from", from?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("projectId", projectId)
                .AddOptionalParameter("projectIds", projectIds, delimiter: ",", explode: true)
                .AddOptionalParameter("target", target)
                .AddOptionalParameter("to", to?.ToString())
                .AddOptionalParameter("users", users)
                .AddOptionalParameter("since", since?.ToString())
                .AddOptionalParameter("until", until?.ToString())
                .AddOptionalParameter("state", state)
                .AddOptionalParameter("rollbackCandidate", rollbackCandidate?.ToString().ToLowerInvariant())
                .AddOptionalParameter("branch", branch)
                .AddOptionalParameter("sha", sha)
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
            PrepareGetDeploymentsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                app: app,
                from: from,
                limit: limit,
                projectId: projectId,
                projectIds: projectIds,
                target: target,
                to: to,
                users: users,
                since: since,
                until: until,
                state: state,
                rollbackCandidate: rollbackCandidate,
                branch: branch,
                sha: sha,
                teamId: teamId,
                slug: slug);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetDeploymentsResponse(
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
            // 
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::Vercel.ApiException(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
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
                ProcessGetDeploymentsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vercel.GetDeploymentsResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Vercel.GetDeploymentsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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