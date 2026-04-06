
#nullable enable

namespace Vercel
{
    public partial class EnvironmentClient
    {
        partial void PrepareListSharedEnvVariableArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? search,
            ref string? projectId,
            ref string? ids,
            ref string? excludeIds,
            ref string? excludeIds2,
            ref string? excludeProjectId,
            ref string? excludeProjectId2,
            ref string? teamId,
            ref string? slug);
        partial void PrepareListSharedEnvVariableRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? search,
            string? projectId,
            string? ids,
            string? excludeIds,
            string? excludeIds2,
            string? excludeProjectId,
            string? excludeProjectId2,
            string? teamId,
            string? slug);
        partial void ProcessListSharedEnvVariableResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListSharedEnvVariableResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Lists all Shared Environment Variables for a team<br/>
        /// Lists all Shared Environment Variables for a team, taking into account optional filters.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="projectId">
        /// Filter SharedEnvVariables that belong to a project<br/>
        /// Example: prj_2WjyKQmM8ZnGcJsPWMrHRHrE
        /// </param>
        /// <param name="ids">
        /// Filter SharedEnvVariables based on comma separated ids<br/>
        /// Example: env_2WjyKQmM8ZnGcJsPWMrHRHrE,env_2WjyKQmM8ZnGcJsPWMrHRCRV
        /// </param>
        /// <param name="excludeIds">
        /// Filter SharedEnvVariables based on comma separated ids<br/>
        /// Example: env_2WjyKQmM8ZnGcJsPWMrHRHrE,env_2WjyKQmM8ZnGcJsPWMrHRCRV
        /// </param>
        /// <param name="excludeIds2">
        /// Filter SharedEnvVariables based on comma separated ids<br/>
        /// Example: env_2WjyKQmM8ZnGcJsPWMrHRHrE,env_2WjyKQmM8ZnGcJsPWMrHRCRV
        /// </param>
        /// <param name="excludeProjectId">
        /// Filter SharedEnvVariables that belong to a project<br/>
        /// Example: prj_2WjyKQmM8ZnGcJsPWMrHRHrE
        /// </param>
        /// <param name="excludeProjectId2">
        /// Filter SharedEnvVariables that belong to a project<br/>
        /// Example: prj_2WjyKQmM8ZnGcJsPWMrHRHrE
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vercel.ListSharedEnvVariableResponse> ListSharedEnvVariableAsync(
            string? search = default,
            string? projectId = default,
            string? ids = default,
            string? excludeIds = default,
            string? excludeIds2 = default,
            string? excludeProjectId = default,
            string? excludeProjectId2 = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListSharedEnvVariableArguments(
                httpClient: HttpClient,
                search: ref search,
                projectId: ref projectId,
                ids: ref ids,
                excludeIds: ref excludeIds,
                excludeIds2: ref excludeIds2,
                excludeProjectId: ref excludeProjectId,
                excludeProjectId2: ref excludeProjectId2,
                teamId: ref teamId,
                slug: ref slug);

            var __pathBuilder = new global::Vercel.PathBuilder(
                path: "/v1/env",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("projectId", projectId)
                .AddOptionalParameter("ids", ids)
                .AddOptionalParameter("exclude_ids", excludeIds)
                .AddOptionalParameter("exclude-ids", excludeIds2)
                .AddOptionalParameter("exclude_projectId", excludeProjectId)
                .AddOptionalParameter("exclude-projectId", excludeProjectId2)
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
            PrepareListSharedEnvVariableRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                search: search,
                projectId: projectId,
                ids: ids,
                excludeIds: excludeIds,
                excludeIds2: excludeIds2,
                excludeProjectId: excludeProjectId,
                excludeProjectId2: excludeProjectId2,
                teamId: teamId,
                slug: slug);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListSharedEnvVariableResponse(
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
                ProcessListSharedEnvVariableResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vercel.ListSharedEnvVariableResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Vercel.ListSharedEnvVariableResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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