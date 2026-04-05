
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel
{
    public partial class ProjectsClient
    {
        partial void PrepareUpdateProjectArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string idOrName,
            ref string? teamId,
            ref string? slug,
            global::Vercel.UpdateProjectRequest request);
        partial void PrepareUpdateProjectRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string idOrName,
            string? teamId,
            string? slug,
            global::Vercel.UpdateProjectRequest request);
        partial void ProcessUpdateProjectResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateProjectResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update an existing project<br/>
        /// Update the fields of a project using either its `name` or `id`.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vercel.UpdateProjectResponse> UpdateProjectAsync(
            string idOrName,

            global::Vercel.UpdateProjectRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateProjectArguments(
                httpClient: HttpClient,
                idOrName: ref idOrName,
                teamId: ref teamId,
                slug: ref slug,
                request: request);

            var __pathBuilder = new global::Vercel.PathBuilder(
                path: $"/v9/projects/{idOrName}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("teamId", teamId)
                .AddOptionalParameter("slug", slug) 
                ; 
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
            PrepareUpdateProjectRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                idOrName: idOrName,
                teamId: teamId,
                slug: slug,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateProjectResponse(
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
            if ((int)__response.StatusCode == 402)
            {
                string? __content_402 = null;
                global::System.Exception? __exception_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_402 = __ex;
                }

                throw new global::Vercel.ApiException(
                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_402,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_402,
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
            if ((int)__response.StatusCode == 409)
            {
                string? __content_409 = null;
                global::System.Exception? __exception_409 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_409 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_409 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_409 = __ex;
                }

                throw new global::Vercel.ApiException(
                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_409,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_409,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 428)
            {
                string? __content_428 = null;
                global::System.Exception? __exception_428 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_428 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_428 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_428 = __ex;
                }

                throw new global::Vercel.ApiException(
                    message: __content_428 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_428,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_428,
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
                ProcessUpdateProjectResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vercel.UpdateProjectResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Vercel.UpdateProjectResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// <summary>
        /// Update an existing project<br/>
        /// Update the fields of a project using either its `name` or `id`.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="autoExposeSystemEnvs"></param>
        /// <param name="autoAssignCustomDomains"></param>
        /// <param name="autoAssignCustomDomainsUpdatedBy"></param>
        /// <param name="buildCommand">
        /// The build command for this project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="commandForIgnoringBuildStep"></param>
        /// <param name="customerSupportCodeVisibility">
        /// Specifies whether customer support can see git source for a deployment
        /// </param>
        /// <param name="devCommand">
        /// The dev command for this project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="directoryListing"></param>
        /// <param name="framework">
        /// The framework that is being used for this project. When `null` is used no framework is selected
        /// </param>
        /// <param name="gitForkProtection">
        /// Specifies whether PRs from Git forks should require a team member's authorization before it can be deployed
        /// </param>
        /// <param name="gitLFS">
        /// Specifies whether Git LFS is enabled for this project.
        /// </param>
        /// <param name="protectedSourcemaps">
        /// Specifies whether sourcemaps are protected and require authentication to access.
        /// </param>
        /// <param name="installCommand">
        /// The install command for this project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="name">
        /// The desired name for the project<br/>
        /// Example: a-project-name
        /// </param>
        /// <param name="nodeVersion"></param>
        /// <param name="outputDirectory">
        /// The output directory of the project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="previewDeploymentsDisabled">
        /// Specifies whether preview deployments are disabled for this project.
        /// </param>
        /// <param name="previewDeploymentSuffix">
        /// Custom domain suffix for preview deployments. Takes precedence over team-level suffix. Must be a domain owned by the team.
        /// </param>
        /// <param name="publicSource">
        /// Specifies whether the source code and logs of the deployments for this project should be public or not
        /// </param>
        /// <param name="resourceConfig">
        /// Specifies resource override configuration for the project
        /// </param>
        /// <param name="rootDirectory">
        /// The name of a directory or relative path to the source code of your project. When `null` is used it will default to the project root
        /// </param>
        /// <param name="serverlessFunctionRegion">
        /// The region to deploy Serverless Functions in this project
        /// </param>
        /// <param name="serverlessFunctionZeroConfigFailover">
        /// Specifies whether Zero Config Failover is enabled for this project.
        /// </param>
        /// <param name="skewProtectionBoundaryAt">
        /// Deployments created before this absolute datetime have Skew Protection disabled. Value is in milliseconds since epoch to match \"createdAt\" fields.
        /// </param>
        /// <param name="skewProtectionMaxAge">
        /// Deployments created before this rolling window have Skew Protection disabled. Value is in seconds to match \"revalidate\" fields.
        /// </param>
        /// <param name="skewProtectionAllowedDomains">
        /// Cross-site domains allowed to fetch skew-protected assets (hostnames, optionally with leading wildcard like *.example.com).
        /// </param>
        /// <param name="sourceFilesOutsideRootDirectory">
        /// Indicates if there are source files outside of the root directory
        /// </param>
        /// <param name="enablePreviewFeedback">
        /// Opt-in to preview toolbar on the project level
        /// </param>
        /// <param name="enableProductionFeedback">
        /// Opt-in to production toolbar on the project level
        /// </param>
        /// <param name="enableAffectedProjectsDeployments">
        /// Opt-in to skip deployments when there are no changes to the root directory and its dependencies
        /// </param>
        /// <param name="enableExternalRewriteCaching">
        /// Specifies whether external rewrite caching is enabled for this project.
        /// </param>
        /// <param name="staticIps">
        /// Manage Static IPs for this project
        /// </param>
        /// <param name="tracing">
        /// Tracing configuration for this project
        /// </param>
        /// <param name="oidcTokenConfig">
        /// OpenID Connect JSON Web Token generation configuration.
        /// </param>
        /// <param name="passwordProtection">
        /// Allows to protect project deployments with a password
        /// </param>
        /// <param name="ssoProtection">
        /// Ensures visitors to your Preview Deployments are logged into Vercel and have a minimum of Viewer access on your team
        /// </param>
        /// <param name="trustedIps">
        /// Restricts access to deployments based on the incoming request IP address
        /// </param>
        /// <param name="optionsAllowlist">
        /// Specify a list of paths that should not be protected by Deployment Protection to enable Cors preflight requests
        /// </param>
        /// <param name="connectConfigurations">
        /// The list of connections from project environment to Secure Compute network
        /// </param>
        /// <param name="dismissedToasts">
        /// An array of objects representing a Dismissed Toast in regards to a Project. Objects are either merged with existing toasts (on key match), or added to the `dimissedToasts` array.`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vercel.UpdateProjectResponse> UpdateProjectAsync(
            string idOrName,
            string? teamId = default,
            string? slug = default,
            bool? autoExposeSystemEnvs = default,
            bool? autoAssignCustomDomains = default,
            string? autoAssignCustomDomainsUpdatedBy = default,
            string? buildCommand = default,
            string? commandForIgnoringBuildStep = default,
            bool? customerSupportCodeVisibility = default,
            string? devCommand = default,
            bool? directoryListing = default,
            global::Vercel.UpdateProjectRequestFramework? framework = default,
            bool? gitForkProtection = default,
            bool? gitLFS = default,
            bool? protectedSourcemaps = default,
            string? installCommand = default,
            string? name = default,
            global::Vercel.UpdateProjectRequestNodeVersion? nodeVersion = default,
            string? outputDirectory = default,
            bool? previewDeploymentsDisabled = default,
            string? previewDeploymentSuffix = default,
            bool? publicSource = default,
            global::Vercel.UpdateProjectRequestResourceConfig? resourceConfig = default,
            string? rootDirectory = default,
            string? serverlessFunctionRegion = default,
            bool? serverlessFunctionZeroConfigFailover = default,
            int? skewProtectionBoundaryAt = default,
            int? skewProtectionMaxAge = default,
            global::System.Collections.Generic.IList<string>? skewProtectionAllowedDomains = default,
            bool? sourceFilesOutsideRootDirectory = default,
            bool? enablePreviewFeedback = default,
            bool? enableProductionFeedback = default,
            bool? enableAffectedProjectsDeployments = default,
            bool? enableExternalRewriteCaching = default,
            global::Vercel.UpdateProjectRequestStaticIps? staticIps = default,
            global::Vercel.UpdateProjectRequestTracing? tracing = default,
            global::Vercel.UpdateProjectRequestOidcTokenConfig? oidcTokenConfig = default,
            global::Vercel.UpdateProjectRequestPasswordProtection? passwordProtection = default,
            global::Vercel.UpdateProjectRequestSsoProtection? ssoProtection = default,
            global::Vercel.UpdateProjectRequestTrustedIps? trustedIps = default,
            global::Vercel.UpdateProjectRequestOptionsAllowlist? optionsAllowlist = default,
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestConnectConfiguration>? connectConfigurations = default,
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestDismissedToast>? dismissedToasts = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vercel.UpdateProjectRequest
            {
                AutoExposeSystemEnvs = autoExposeSystemEnvs,
                AutoAssignCustomDomains = autoAssignCustomDomains,
                AutoAssignCustomDomainsUpdatedBy = autoAssignCustomDomainsUpdatedBy,
                BuildCommand = buildCommand,
                CommandForIgnoringBuildStep = commandForIgnoringBuildStep,
                CustomerSupportCodeVisibility = customerSupportCodeVisibility,
                DevCommand = devCommand,
                DirectoryListing = directoryListing,
                Framework = framework,
                GitForkProtection = gitForkProtection,
                GitLFS = gitLFS,
                ProtectedSourcemaps = protectedSourcemaps,
                InstallCommand = installCommand,
                Name = name,
                NodeVersion = nodeVersion,
                OutputDirectory = outputDirectory,
                PreviewDeploymentsDisabled = previewDeploymentsDisabled,
                PreviewDeploymentSuffix = previewDeploymentSuffix,
                PublicSource = publicSource,
                ResourceConfig = resourceConfig,
                RootDirectory = rootDirectory,
                ServerlessFunctionRegion = serverlessFunctionRegion,
                ServerlessFunctionZeroConfigFailover = serverlessFunctionZeroConfigFailover,
                SkewProtectionBoundaryAt = skewProtectionBoundaryAt,
                SkewProtectionMaxAge = skewProtectionMaxAge,
                SkewProtectionAllowedDomains = skewProtectionAllowedDomains,
                SourceFilesOutsideRootDirectory = sourceFilesOutsideRootDirectory,
                EnablePreviewFeedback = enablePreviewFeedback,
                EnableProductionFeedback = enableProductionFeedback,
                EnableAffectedProjectsDeployments = enableAffectedProjectsDeployments,
                EnableExternalRewriteCaching = enableExternalRewriteCaching,
                StaticIps = staticIps,
                Tracing = tracing,
                OidcTokenConfig = oidcTokenConfig,
                PasswordProtection = passwordProtection,
                SsoProtection = ssoProtection,
                TrustedIps = trustedIps,
                OptionsAllowlist = optionsAllowlist,
                ConnectConfigurations = connectConfigurations,
                DismissedToasts = dismissedToasts,
            };

            return await UpdateProjectAsync(
                idOrName: idOrName,
                teamId: teamId,
                slug: slug,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}