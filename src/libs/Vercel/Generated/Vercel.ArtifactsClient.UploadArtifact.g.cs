
#nullable enable

namespace Vercel
{
    public partial class ArtifactsClient
    {


        private static readonly global::Vercel.EndPointSecurityRequirement s_UploadArtifactSecurityRequirement0 =
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
        private static readonly global::Vercel.EndPointSecurityRequirement[] s_UploadArtifactSecurityRequirements =
            new global::Vercel.EndPointSecurityRequirement[]
            {                s_UploadArtifactSecurityRequirement0,
            };
        partial void PrepareUploadArtifactArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref double contentLength,
            ref double? xArtifactDuration,
            ref string? xArtifactClientCi,
            ref int? xArtifactClientInteractive,
            ref string? xArtifactTag,
            ref string? xArtifactSha,
            ref string? xArtifactDirtyHash,
            ref string hash,
            ref string? teamId,
            ref string? slug,
            byte[] request);
        partial void PrepareUploadArtifactRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            double contentLength,
            double? xArtifactDuration,
            string? xArtifactClientCi,
            int? xArtifactClientInteractive,
            string? xArtifactTag,
            string? xArtifactSha,
            string? xArtifactDirtyHash,
            string hash,
            string? teamId,
            string? slug,
            byte[] request);
        partial void ProcessUploadArtifactResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadArtifactResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload a cache artifact<br/>
        /// Uploads a cache artifact identified by the `hash` specified on the path. The cache artifact can then be downloaded with the provided `hash`.
        /// </summary>
        /// <param name="contentLength">
        /// The artifact size in bytes
        /// </param>
        /// <param name="xArtifactDuration">
        /// The time taken to generate the uploaded artifact in milliseconds.<br/>
        /// Example: 400
        /// </param>
        /// <param name="xArtifactClientCi">
        /// The continuous integration or delivery environment where this artifact was generated.<br/>
        /// Example: VERCEL
        /// </param>
        /// <param name="xArtifactClientInteractive">
        /// 1 if the client is an interactive shell. Otherwise 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="xArtifactTag">
        /// The base64 encoded tag for this artifact. The value is sent back to clients when the artifact is downloaded as the header `x-artifact-tag`<br/>
        /// Example: Tc0BmHvJYMIYJ62/zx87YqO0Flxk+5Ovip25NY825CQ=
        /// </param>
        /// <param name="xArtifactSha">
        /// The SHA of the source control revision that generated this artifact.
        /// </param>
        /// <param name="xArtifactDirtyHash">
        /// A hash representing uncommitted changes in the working directory when this artifact was generated.
        /// </param>
        /// <param name="hash">
        /// The artifact hash<br/>
        /// Example: 12HKQaOmR5t5Uy6vdcQsNIiZgHGB
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
        public async global::System.Threading.Tasks.Task<global::Vercel.UploadArtifactResponse> UploadArtifactAsync(
            double contentLength,
            string hash,

            byte[] request,
            double? xArtifactDuration = default,
            string? xArtifactClientCi = default,
            int? xArtifactClientInteractive = default,
            string? xArtifactTag = default,
            string? xArtifactSha = default,
            string? xArtifactDirtyHash = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadArtifactArguments(
                httpClient: HttpClient,
                contentLength: ref contentLength,
                xArtifactDuration: ref xArtifactDuration,
                xArtifactClientCi: ref xArtifactClientCi,
                xArtifactClientInteractive: ref xArtifactClientInteractive,
                xArtifactTag: ref xArtifactTag,
                xArtifactSha: ref xArtifactSha,
                xArtifactDirtyHash: ref xArtifactDirtyHash,
                hash: ref hash,
                teamId: ref teamId,
                slug: ref slug,
                request: request);


            var __authorizations = global::Vercel.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UploadArtifactSecurityRequirements,
                operationName: "UploadArtifactAsync");

            var __pathBuilder = new global::Vercel.PathBuilder(
                path: $"/v8/artifacts/{hash}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("teamId", teamId)
                .AddOptionalParameter("slug", slug) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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

            __httpRequest.Headers.TryAddWithoutValidation("Content-Length", contentLength.ToString());
            if (xArtifactDuration != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-artifact-duration", xArtifactDuration.ToString());
            }
            if (xArtifactClientCi != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-artifact-client-ci", xArtifactClientCi.ToString());
            }
            if (xArtifactClientInteractive != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-artifact-client-interactive", xArtifactClientInteractive.ToString());
            }
            if (xArtifactTag != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-artifact-tag", xArtifactTag.ToString());
            }
            if (xArtifactSha != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-artifact-sha", xArtifactSha.ToString());
            }
            if (xArtifactDirtyHash != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-artifact-dirty-hash", xArtifactDirtyHash.ToString());
            }


            var __httpRequestContent = new global::System.Net.Http.ByteArrayContent(request);
            __httpRequestContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUploadArtifactRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                contentLength: contentLength,
                xArtifactDuration: xArtifactDuration,
                xArtifactClientCi: xArtifactClientCi,
                xArtifactClientInteractive: xArtifactClientInteractive,
                xArtifactTag: xArtifactTag,
                xArtifactSha: xArtifactSha,
                xArtifactDirtyHash: xArtifactDirtyHash,
                hash: hash,
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
            ProcessUploadArtifactResponse(
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
                ProcessUploadArtifactResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vercel.UploadArtifactResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Vercel.UploadArtifactResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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