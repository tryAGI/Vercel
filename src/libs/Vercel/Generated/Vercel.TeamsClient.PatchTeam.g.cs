
#nullable enable

namespace Vercel
{
    public partial class TeamsClient
    {
        partial void PreparePatchTeamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string teamId,
            ref string? slug,
            global::Vercel.PatchTeamRequest request);
        partial void PreparePatchTeamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string teamId,
            string? slug,
            global::Vercel.PatchTeamRequest request);
        partial void ProcessPatchTeamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPatchTeamResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a Team<br/>
        /// Update the information of a Team specified by the `teamId` parameter. The request body should contain the information that will be updated on the Team.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vercel.Team> PatchTeamAsync(
            string teamId,

            global::Vercel.PatchTeamRequest request,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePatchTeamArguments(
                httpClient: HttpClient,
                teamId: ref teamId,
                slug: ref slug,
                request: request);

            var __pathBuilder = new global::Vercel.PathBuilder(
                path: $"/v2/teams/{teamId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePatchTeamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
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
            ProcessPatchTeamResponse(
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
                ProcessPatchTeamResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vercel.Team.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Vercel.Team.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Update a Team<br/>
        /// Update the information of a Team specified by the `teamId` parameter. The request body should contain the information that will be updated on the Team.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="avatar">
        /// The hash value of an uploaded image.
        /// </param>
        /// <param name="description">
        /// A short text that describes the team.<br/>
        /// Example: Our mission is to make cloud computing accessible to everyone
        /// </param>
        /// <param name="emailDomain">
        /// Example: example.com
        /// </param>
        /// <param name="name">
        /// The name of the team.<br/>
        /// Example: My Team
        /// </param>
        /// <param name="previewDeploymentSuffix">
        /// Suffix that will be used for all preview deployments.<br/>
        /// Example: example.dev
        /// </param>
        /// <param name="regenerateInviteCode">
        /// Create a new invite code and replace the current one.<br/>
        /// Example: true
        /// </param>
        /// <param name="saml"></param>
        /// <param name="requestSlug">
        /// A new slug for the team.<br/>
        /// Example: my-team
        /// </param>
        /// <param name="enablePreviewFeedback">
        /// Enable preview toolbar: one of on, off or default.<br/>
        /// Example: on
        /// </param>
        /// <param name="enableProductionFeedback">
        /// Enable production toolbar: one of on, off or default.<br/>
        /// Example: on
        /// </param>
        /// <param name="sensitiveEnvironmentVariablePolicy">
        /// Sensitive environment variable policy: one of on, off or default.<br/>
        /// Example: on
        /// </param>
        /// <param name="remoteCaching">
        /// Whether or not remote caching is enabled for the team
        /// </param>
        /// <param name="hideIpAddresses">
        /// Display or hide IP addresses in Monitoring queries.<br/>
        /// Example: false
        /// </param>
        /// <param name="hideIpAddressesInLogDrains">
        /// Display or hide IP addresses in Log Drains.<br/>
        /// Example: false
        /// </param>
        /// <param name="defaultDeploymentProtection">
        /// Default deployment protection settings for new projects.
        /// </param>
        /// <param name="defaultExpirationSettings"></param>
        /// <param name="strictDeploymentProtectionSettings">
        /// When enabled, deployment protection settings require stricter permissions (owner-only).
        /// </param>
        /// <param name="nsnbConfig"></param>
        /// <param name="resourceConfig">
        /// Resource configuration for the team.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vercel.Team> PatchTeamAsync(
            string teamId,
            string? slug = default,
            string? avatar = default,
            string? description = default,
            string? emailDomain = default,
            string? name = default,
            string? previewDeploymentSuffix = default,
            bool? regenerateInviteCode = default,
            global::Vercel.PatchTeamRequestSaml? saml = default,
            string? requestSlug = default,
            string? enablePreviewFeedback = default,
            string? enableProductionFeedback = default,
            string? sensitiveEnvironmentVariablePolicy = default,
            global::Vercel.PatchTeamRequestRemoteCaching? remoteCaching = default,
            bool? hideIpAddresses = default,
            bool? hideIpAddressesInLogDrains = default,
            global::Vercel.PatchTeamRequestDefaultDeploymentProtection? defaultDeploymentProtection = default,
            global::Vercel.PatchTeamRequestDefaultExpirationSettings? defaultExpirationSettings = default,
            global::Vercel.PatchTeamRequestStrictDeploymentProtectionSettings? strictDeploymentProtectionSettings = default,
            global::Vercel.AnyOf<global::Vercel.PatchTeamRequestNsnbConfig, string>? nsnbConfig = default,
            global::Vercel.PatchTeamRequestResourceConfig? resourceConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vercel.PatchTeamRequest
            {
                Avatar = avatar,
                Description = description,
                EmailDomain = emailDomain,
                Name = name,
                PreviewDeploymentSuffix = previewDeploymentSuffix,
                RegenerateInviteCode = regenerateInviteCode,
                Saml = saml,
                Slug = requestSlug,
                EnablePreviewFeedback = enablePreviewFeedback,
                EnableProductionFeedback = enableProductionFeedback,
                SensitiveEnvironmentVariablePolicy = sensitiveEnvironmentVariablePolicy,
                RemoteCaching = remoteCaching,
                HideIpAddresses = hideIpAddresses,
                HideIpAddressesInLogDrains = hideIpAddressesInLogDrains,
                DefaultDeploymentProtection = defaultDeploymentProtection,
                DefaultExpirationSettings = defaultExpirationSettings,
                StrictDeploymentProtectionSettings = strictDeploymentProtectionSettings,
                NsnbConfig = nsnbConfig,
                ResourceConfig = resourceConfig,
            };

            return await PatchTeamAsync(
                teamId: teamId,
                slug: slug,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}