
#nullable enable

namespace Vercel
{
    public partial class DeploymentsClient
    {
        partial void PrepareCreateDeploymentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Vercel.CreateDeploymentForceNew? forceNew,
            ref global::Vercel.CreateDeploymentSkipAutoDetectionConfirmation? skipAutoDetectionConfirmation,
            ref string? teamId,
            ref string? slug,
            global::Vercel.CreateDeploymentRequest request);
        partial void PrepareCreateDeploymentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Vercel.CreateDeploymentForceNew? forceNew,
            global::Vercel.CreateDeploymentSkipAutoDetectionConfirmation? skipAutoDetectionConfirmation,
            string? teamId,
            string? slug,
            global::Vercel.CreateDeploymentRequest request);
        partial void ProcessCreateDeploymentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateDeploymentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a new deployment<br/>
        /// Create a new deployment with all the required and intended data. If the deployment is not a git deployment, all files must be provided with the request, either referenced or inlined. Additionally, a deployment id can be specified to redeploy a previous deployment.
        /// </summary>
        /// <param name="forceNew">
        /// Forces a new deployment even if there is a previous similar deployment
        /// </param>
        /// <param name="skipAutoDetectionConfirmation">
        /// Allows to skip framework detection so the API would not fail to ask for confirmation
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
        public async global::System.Threading.Tasks.Task<global::Vercel.CreateDeploymentResponse> CreateDeploymentAsync(

            global::Vercel.CreateDeploymentRequest request,
            global::Vercel.CreateDeploymentForceNew? forceNew = default,
            global::Vercel.CreateDeploymentSkipAutoDetectionConfirmation? skipAutoDetectionConfirmation = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateDeploymentArguments(
                httpClient: HttpClient,
                forceNew: ref forceNew,
                skipAutoDetectionConfirmation: ref skipAutoDetectionConfirmation,
                teamId: ref teamId,
                slug: ref slug,
                request: request);

            var __pathBuilder = new global::Vercel.PathBuilder(
                path: "/v13/deployments",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("forceNew", forceNew?.ToValueString())
                .AddOptionalParameter("skipAutoDetectionConfirmation", skipAutoDetectionConfirmation?.ToValueString())
                .AddOptionalParameter("teamId", teamId)
                .AddOptionalParameter("slug", slug) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareCreateDeploymentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                forceNew: forceNew,
                skipAutoDetectionConfirmation: skipAutoDetectionConfirmation,
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
            ProcessCreateDeploymentResponse(
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
            if ((int)__response.StatusCode == 426)
            {
                string? __content_426 = null;
                global::System.Exception? __exception_426 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_426 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_426 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_426 = __ex;
                }

                throw new global::Vercel.ApiException(
                    message: __content_426 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_426,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_426,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::Vercel.ApiException(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
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
            // 
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::System.Exception? __exception_503 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_503 = __ex;
                }

                throw new global::Vercel.ApiException(
                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_503,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_503,
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
                ProcessCreateDeploymentResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vercel.CreateDeploymentResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Vercel.CreateDeploymentResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create a new deployment<br/>
        /// Create a new deployment with all the required and intended data. If the deployment is not a git deployment, all files must be provided with the request, either referenced or inlined. Additionally, a deployment id can be specified to redeploy a previous deployment.
        /// </summary>
        /// <param name="forceNew">
        /// Forces a new deployment even if there is a previous similar deployment
        /// </param>
        /// <param name="skipAutoDetectionConfirmation">
        /// Allows to skip framework detection so the API would not fail to ask for confirmation
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="customEnvironmentSlugOrId">
        /// Deploy to a custom environment, which will override the default environment
        /// </param>
        /// <param name="deploymentId">
        /// An deployment id for an existing deployment to redeploy<br/>
        /// Example: dpl_2qn7PZrx89yxY34vEZPD31Y9XVj6
        /// </param>
        /// <param name="files">
        /// A list of objects with the files to be deployed
        /// </param>
        /// <param name="gitMetadata">
        /// Populates initial git metadata for different git providers.
        /// </param>
        /// <param name="gitSource">
        /// Defines the Git Repository source to be deployed. This property can not be used in combination with `files`.
        /// </param>
        /// <param name="meta">
        /// An object containing the deployment's metadata. Multiple key-value pairs can be attached to a deployment<br/>
        /// Example: {"foo":"bar"}
        /// </param>
        /// <param name="monorepoManager">
        /// The monorepo manager that is being used for this deployment. When `null` is used no monorepo manager is selected
        /// </param>
        /// <param name="name">
        /// A string with the project name used in the deployment URL<br/>
        /// Example: my-instant-deployment
        /// </param>
        /// <param name="project">
        /// The target project identifier in which the deployment will be created. When defined, this parameter overrides name<br/>
        /// Example: my-deployment-project
        /// </param>
        /// <param name="projectSettings">
        /// Project settings that will be applied to the deployment. It is required for the first deployment of a project and will be saved for any following deployments
        /// </param>
        /// <param name="target">
        /// Either not defined, `staging`, `production`, or a custom environment identifier. If `staging`, a staging alias in the format `&lt;project&gt;-&lt;team&gt;.vercel.app` will be assigned. If `production`, any aliases defined in `alias` will be assigned. If omitted, the target will be `preview`.<br/>
        /// Example: production
        /// </param>
        /// <param name="withLatestCommit">
        /// When `true` and `deploymentId` is passed in, the sha from the previous deployment's `gitSource` is removed forcing the latest commit to be used.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vercel.CreateDeploymentResponse> CreateDeploymentAsync(
            string name,
            global::Vercel.CreateDeploymentForceNew? forceNew = default,
            global::Vercel.CreateDeploymentSkipAutoDetectionConfirmation? skipAutoDetectionConfirmation = default,
            string? teamId = default,
            string? slug = default,
            string? customEnvironmentSlugOrId = default,
            string? deploymentId = default,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateDeploymentRequestFileInlinedFile, global::Vercel.CreateDeploymentRequestFileUploadedFile>>? files = default,
            global::Vercel.CreateDeploymentRequestGitMetadata? gitMetadata = default,
            global::Vercel.AnyOf<global::Vercel.CreateDeploymentRequestGitSourceVariant1, global::Vercel.CreateDeploymentRequestGitSourceVariant2, global::Vercel.CreateDeploymentRequestGitSourceVariant3, global::Vercel.CreateDeploymentRequestGitSourceVariant4, global::Vercel.CreateDeploymentRequestGitSourceVariant5, global::Vercel.CreateDeploymentRequestGitSourceVariant6, global::Vercel.CreateDeploymentRequestGitSourceVariant7, global::Vercel.CreateDeploymentRequestGitSourceVariant8>? gitSource = default,
            global::System.Collections.Generic.Dictionary<string, string>? meta = default,
            string? monorepoManager = default,
            string? project = default,
            global::Vercel.CreateDeploymentRequestProjectSettings? projectSettings = default,
            string? target = default,
            bool? withLatestCommit = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vercel.CreateDeploymentRequest
            {
                CustomEnvironmentSlugOrId = customEnvironmentSlugOrId,
                DeploymentId = deploymentId,
                Files = files,
                GitMetadata = gitMetadata,
                GitSource = gitSource,
                Meta = meta,
                MonorepoManager = monorepoManager,
                Name = name,
                Project = project,
                ProjectSettings = projectSettings,
                Target = target,
                WithLatestCommit = withLatestCommit,
            };

            return await CreateDeploymentAsync(
                forceNew: forceNew,
                skipAutoDetectionConfirmation: skipAutoDetectionConfirmation,
                teamId: teamId,
                slug: slug,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}