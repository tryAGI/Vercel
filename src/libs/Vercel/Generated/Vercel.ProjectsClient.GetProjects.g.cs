
#nullable enable

namespace Vercel
{
    public partial class ProjectsClient
    {


        private static readonly global::Vercel.EndPointSecurityRequirement s_GetProjectsSecurityRequirement0 =
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
        private static readonly global::Vercel.EndPointSecurityRequirement[] s_GetProjectsSecurityRequirements =
            new global::Vercel.EndPointSecurityRequirement[]
            {                s_GetProjectsSecurityRequirement0,
            };
        partial void PrepareGetProjectsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? from,
            ref global::Vercel.GetProjectsGitForkProtection? gitForkProtection,
            ref string? limit,
            ref string? search,
            ref string? repo,
            ref string? repoId,
            ref string? repoUrl,
            ref string? excludeRepos,
            ref string? edgeConfigId,
            ref string? edgeConfigTokenId,
            ref bool? deprecated,
            ref global::Vercel.GetProjectsElasticConcurrencyEnabled? elasticConcurrencyEnabled,
            ref global::Vercel.GetProjectsStaticIpsEnabled? staticIpsEnabled,
            ref string? buildMachineTypes,
            ref global::Vercel.GetProjectsBuildQueueConfiguration? buildQueueConfiguration,
            ref string? teamId,
            ref string? slug);
        partial void PrepareGetProjectsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? from,
            global::Vercel.GetProjectsGitForkProtection? gitForkProtection,
            string? limit,
            string? search,
            string? repo,
            string? repoId,
            string? repoUrl,
            string? excludeRepos,
            string? edgeConfigId,
            string? edgeConfigTokenId,
            bool? deprecated,
            global::Vercel.GetProjectsElasticConcurrencyEnabled? elasticConcurrencyEnabled,
            global::Vercel.GetProjectsStaticIpsEnabled? staticIpsEnabled,
            string? buildMachineTypes,
            global::Vercel.GetProjectsBuildQueueConfiguration? buildQueueConfiguration,
            string? teamId,
            string? slug);
        partial void ProcessGetProjectsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetProjectsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve a list of projects<br/>
        /// Allows to retrieve the list of projects of the authenticated user or team. The list will be paginated and the provided query parameters allow filtering the returned projects.
        /// </summary>
        /// <param name="from">
        /// Query only projects updated after the given timestamp or continuation token.
        /// </param>
        /// <param name="gitForkProtection">
        /// Specifies whether PRs from Git forks should require a team member's authorization before it can be deployed<br/>
        /// Example: 1
        /// </param>
        /// <param name="limit">
        /// Limit the number of projects returned
        /// </param>
        /// <param name="search">
        /// Search projects by the name field
        /// </param>
        /// <param name="repo">
        /// Filter results by repo. Also used for project count
        /// </param>
        /// <param name="repoId">
        /// Filter results by Repository ID.
        /// </param>
        /// <param name="repoUrl">
        /// Filter results by Repository URL.<br/>
        /// Example: https://github.com/vercel/next.js
        /// </param>
        /// <param name="excludeRepos">
        /// Filter results by excluding those projects that belong to a repo
        /// </param>
        /// <param name="edgeConfigId">
        /// Filter results by connected Edge Config ID
        /// </param>
        /// <param name="edgeConfigTokenId">
        /// Filter results by connected Edge Config Token ID
        /// </param>
        /// <param name="deprecated"></param>
        /// <param name="elasticConcurrencyEnabled">
        /// Filter results by projects with elastic concurrency enabled<br/>
        /// Example: 1
        /// </param>
        /// <param name="staticIpsEnabled">
        /// Filter results by projects with Static IPs enabled<br/>
        /// Example: 1
        /// </param>
        /// <param name="buildMachineTypes">
        /// Filter results by build machine types. Accepts comma-separated values. Use \"default\" for projects without a build machine type set.<br/>
        /// Example: default,enhanced
        /// </param>
        /// <param name="buildQueueConfiguration">
        /// Filter results by build queue configuration. SKIP_NAMESPACE_QUEUE includes projects without a configuration set.<br/>
        /// Example: SKIP_NAMESPACE_QUEUE
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1Item>, global::Vercel.GetProjectsResponseVariant2, global::Vercel.GetProjectsResponseVariant3>> GetProjectsAsync(
            string? from = default,
            global::Vercel.GetProjectsGitForkProtection? gitForkProtection = default,
            string? limit = default,
            string? search = default,
            string? repo = default,
            string? repoId = default,
            string? repoUrl = default,
            string? excludeRepos = default,
            string? edgeConfigId = default,
            string? edgeConfigTokenId = default,
            bool? deprecated = default,
            global::Vercel.GetProjectsElasticConcurrencyEnabled? elasticConcurrencyEnabled = default,
            global::Vercel.GetProjectsStaticIpsEnabled? staticIpsEnabled = default,
            string? buildMachineTypes = default,
            global::Vercel.GetProjectsBuildQueueConfiguration? buildQueueConfiguration = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetProjectsArguments(
                httpClient: HttpClient,
                from: ref from,
                gitForkProtection: ref gitForkProtection,
                limit: ref limit,
                search: ref search,
                repo: ref repo,
                repoId: ref repoId,
                repoUrl: ref repoUrl,
                excludeRepos: ref excludeRepos,
                edgeConfigId: ref edgeConfigId,
                edgeConfigTokenId: ref edgeConfigTokenId,
                deprecated: ref deprecated,
                elasticConcurrencyEnabled: ref elasticConcurrencyEnabled,
                staticIpsEnabled: ref staticIpsEnabled,
                buildMachineTypes: ref buildMachineTypes,
                buildQueueConfiguration: ref buildQueueConfiguration,
                teamId: ref teamId,
                slug: ref slug);


            var __authorizations = global::Vercel.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetProjectsSecurityRequirements,
                operationName: "GetProjectsAsync");

            var __pathBuilder = new global::Vercel.PathBuilder(
                path: "/v10/projects",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("from", from)
                .AddOptionalParameter("gitForkProtection", gitForkProtection?.ToValueString())
                .AddOptionalParameter("limit", limit)
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("repo", repo)
                .AddOptionalParameter("repoId", repoId)
                .AddOptionalParameter("repoUrl", repoUrl)
                .AddOptionalParameter("excludeRepos", excludeRepos)
                .AddOptionalParameter("edgeConfigId", edgeConfigId)
                .AddOptionalParameter("edgeConfigTokenId", edgeConfigTokenId)
                .AddOptionalParameter("deprecated", deprecated?.ToString().ToLowerInvariant())
                .AddOptionalParameter("elasticConcurrencyEnabled", elasticConcurrencyEnabled?.ToValueString())
                .AddOptionalParameter("staticIpsEnabled", staticIpsEnabled?.ToValueString())
                .AddOptionalParameter("buildMachineTypes", buildMachineTypes)
                .AddOptionalParameter("buildQueueConfiguration", buildQueueConfiguration?.ToValueString())
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
            PrepareGetProjectsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                from: from,
                gitForkProtection: gitForkProtection,
                limit: limit,
                search: search,
                repo: repo,
                repoId: repoId,
                repoUrl: repoUrl,
                excludeRepos: excludeRepos,
                edgeConfigId: edgeConfigId,
                edgeConfigTokenId: edgeConfigTokenId,
                deprecated: deprecated,
                elasticConcurrencyEnabled: elasticConcurrencyEnabled,
                staticIpsEnabled: staticIpsEnabled,
                buildMachineTypes: buildMachineTypes,
                buildQueueConfiguration: buildQueueConfiguration,
                teamId: teamId,
                slug: slug);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetProjectsResponse(
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
                ProcessGetProjectsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1Item>, global::Vercel.GetProjectsResponseVariant2, global::Vercel.GetProjectsResponseVariant3>.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1Item>, global::Vercel.GetProjectsResponseVariant2, global::Vercel.GetProjectsResponseVariant3>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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