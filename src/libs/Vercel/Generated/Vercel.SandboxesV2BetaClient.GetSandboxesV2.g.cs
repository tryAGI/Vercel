
#nullable enable

namespace Vercel
{
    public partial class SandboxesV2BetaClient
    {


        private static readonly global::Vercel.EndPointSecurityRequirement s_GetSandboxesV2SecurityRequirement0 =
            new global::Vercel.EndPointSecurityRequirement
            {
                Authorizations = new global::Vercel.EndPointAuthorizationRequirement[]
                {                    new global::Vercel.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Vercel.EndPointSecurityRequirement[] s_GetSandboxesV2SecurityRequirements =
            new global::Vercel.EndPointSecurityRequirement[]
            {                s_GetSandboxesV2SecurityRequirement0,
            };
        partial void PrepareGetSandboxesV2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? project,
            ref double? limit,
            ref global::Vercel.GetSandboxesV2SortBy? sortBy,
            ref string? namePrefix,
            ref string? cursor,
            ref global::Vercel.GetSandboxesV2SortOrder? sortOrder,
            ref global::Vercel.AnyOf<string, global::System.Collections.Generic.IList<string>>? tags,
            ref string? teamId,
            ref string? slug);
        partial void PrepareGetSandboxesV2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? project,
            double? limit,
            global::Vercel.GetSandboxesV2SortBy? sortBy,
            string? namePrefix,
            string? cursor,
            global::Vercel.GetSandboxesV2SortOrder? sortOrder,
            global::Vercel.AnyOf<string, global::System.Collections.Generic.IList<string>>? tags,
            string? teamId,
            string? slug);
        partial void ProcessGetSandboxesV2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSandboxesV2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List sandboxes<br/>
        /// Retrieves a paginated list of named sandboxes belonging to a specific project. Results can be sorted by creation time or name, and optionally filtered by name prefix.
        /// </summary>
        /// <param name="project">
        /// The unique identifier or name of the project to list named sandboxes for.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="limit">
        /// Maximum number of named sandboxes to return in the response. Used for pagination.<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="sortBy">
        /// Field to sort by.<br/>
        /// Default Value: createdAt
        /// </param>
        /// <param name="namePrefix">
        /// Filter named sandboxes whose name starts with this prefix. Only valid when sortBy=name.
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor from a previous response.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Defaults to desc.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="tags">
        /// Filter sandboxes by tag. Format: \"key:value\". Only one tag filter is supported at a time.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vercel.GetSandboxesV2Response> GetSandboxesV2Async(
            string? project = default,
            double? limit = default,
            global::Vercel.GetSandboxesV2SortBy? sortBy = default,
            string? namePrefix = default,
            string? cursor = default,
            global::Vercel.GetSandboxesV2SortOrder? sortOrder = default,
            global::Vercel.AnyOf<string, global::System.Collections.Generic.IList<string>>? tags = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetSandboxesV2Arguments(
                httpClient: HttpClient,
                project: ref project,
                limit: ref limit,
                sortBy: ref sortBy,
                namePrefix: ref namePrefix,
                cursor: ref cursor,
                sortOrder: ref sortOrder,
                tags: ref tags,
                teamId: ref teamId,
                slug: ref slug);


            var __authorizations = global::Vercel.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetSandboxesV2SecurityRequirements,
                operationName: "GetSandboxesV2Async");

            var __pathBuilder = new global::Vercel.PathBuilder(
                path: "/v2/sandboxes",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("project", project)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("sortBy", sortBy?.ToValueString())
                .AddOptionalParameter("namePrefix", namePrefix)
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("sortOrder", sortOrder?.ToValueString())
                .AddOptionalParameter("tags", tags?.ToString())
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

            foreach (var __authorization in __authorizations)
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
            PrepareGetSandboxesV2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                project: project,
                limit: limit,
                sortBy: sortBy,
                namePrefix: namePrefix,
                cursor: cursor,
                sortOrder: sortOrder,
                tags: tags,
                teamId: teamId,
                slug: slug);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetSandboxesV2Response(
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
                ProcessGetSandboxesV2ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vercel.GetSandboxesV2Response.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Vercel.GetSandboxesV2Response.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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