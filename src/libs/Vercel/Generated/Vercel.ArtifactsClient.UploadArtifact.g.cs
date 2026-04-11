
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
                        SchemeId = "HttpBearer",
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
            ref double? x_contentLength_,
            ref double? x_xArtifactDuration_,
            ref string? x_xArtifactClientCi_,
            ref int? x_xArtifactClientInteractive_,
            ref string? x_xArtifactTag_,
            ref string? x_xArtifactSha_,
            ref string? x_xArtifactDirtyHash_,
            ref string hash,
            ref string? teamId,
            ref string? slug,
            byte[] request);
        partial void PrepareUploadArtifactRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            double? x_contentLength_,
            double? x_xArtifactDuration_,
            string? x_xArtifactClientCi_,
            int? x_xArtifactClientInteractive_,
            string? x_xArtifactTag_,
            string? x_xArtifactSha_,
            string? x_xArtifactDirtyHash_,
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
        /// <param name="x_contentLength_">
        /// The artifact size in bytes
        /// </param>
        /// <param name="x_xArtifactDuration_">
        /// The time taken to generate the uploaded artifact in milliseconds.<br/>
        /// Example: 400
        /// </param>
        /// <param name="x_xArtifactClientCi_">
        /// The continuous integration or delivery environment where this artifact was generated.<br/>
        /// Example: VERCEL
        /// </param>
        /// <param name="x_xArtifactClientInteractive_">
        /// 1 if the client is an interactive shell. Otherwise 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="x_xArtifactTag_">
        /// The base64 encoded tag for this artifact. The value is sent back to clients when the artifact is downloaded as the header `x-artifact-tag`<br/>
        /// Example: Tc0BmHvJYMIYJ62/zx87YqO0Flxk+5Ovip25NY825CQ=
        /// </param>
        /// <param name="x_xArtifactSha_">
        /// The SHA of the source control revision that generated this artifact.
        /// </param>
        /// <param name="x_xArtifactDirtyHash_">
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vercel.UploadArtifactResponse> UploadArtifactAsync(
            string hash,

            byte[] request,
            double? x_contentLength_ = default,
            double? x_xArtifactDuration_ = default,
            string? x_xArtifactClientCi_ = default,
            int? x_xArtifactClientInteractive_ = default,
            string? x_xArtifactTag_ = default,
            string? x_xArtifactSha_ = default,
            string? x_xArtifactDirtyHash_ = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadArtifactArguments(
                httpClient: HttpClient,
                x_contentLength_: ref x_contentLength_,
                x_xArtifactDuration_: ref x_xArtifactDuration_,
                x_xArtifactClientCi_: ref x_xArtifactClientCi_,
                x_xArtifactClientInteractive_: ref x_xArtifactClientInteractive_,
                x_xArtifactTag_: ref x_xArtifactTag_,
                x_xArtifactSha_: ref x_xArtifactSha_,
                x_xArtifactDirtyHash_: ref x_xArtifactDirtyHash_,
                hash: ref hash,
                teamId: ref teamId,
                slug: ref slug,
                request: request);


            var __authorizations = global::Vercel.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UploadArtifactSecurityRequirements,
                operationName: "UploadArtifactAsync");

            using var __timeoutCancellationTokenSource = global::Vercel.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Vercel.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Vercel.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Vercel.PathBuilder(
                                path: $"/v8/artifacts/{hash}",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("teamId", teamId)
                                .AddOptionalParameter("slug", slug) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Vercel.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Put,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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

            if (x_contentLength_ != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("'content-Length'", x_contentLength_.ToString());
            }
            if (x_xArtifactDuration_ != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("'x-Artifact-Duration'", x_xArtifactDuration_.ToString());
            }
            if (x_xArtifactClientCi_ != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("'x-Artifact-Client-Ci'", x_xArtifactClientCi_.ToString());
            }
            if (x_xArtifactClientInteractive_ != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("'x-Artifact-Client-Interactive'", x_xArtifactClientInteractive_.ToString());
            }
            if (x_xArtifactTag_ != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("'x-Artifact-Tag'", x_xArtifactTag_.ToString());
            }
            if (x_xArtifactSha_ != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("'x-Artifact-Sha'", x_xArtifactSha_.ToString());
            }
            if (x_xArtifactDirtyHash_ != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("'x-Artifact-Dirty-Hash'", x_xArtifactDirtyHash_.ToString());
            }


                            var __httpRequestContent = new global::System.Net.Http.ByteArrayContent(request);
                            __httpRequestContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                            __httpRequest.Content = __httpRequestContent;
                global::Vercel.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareUploadArtifactRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    x_contentLength_: x_contentLength_,
                    x_xArtifactDuration_: x_xArtifactDuration_,
                    x_xArtifactClientCi_: x_xArtifactClientCi_,
                    x_xArtifactClientInteractive_: x_xArtifactClientInteractive_,
                    x_xArtifactTag_: x_xArtifactTag_,
                    x_xArtifactSha_: x_xArtifactSha_,
                    x_xArtifactDirtyHash_: x_xArtifactDirtyHash_,
                    hash: hash,
                    teamId: teamId,
                    slug: slug,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Vercel.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Vercel.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UploadArtifact",
                                methodName: "UploadArtifactAsync",
                                pathTemplate: "$\"/v8/artifacts/{hash}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Vercel.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Vercel.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UploadArtifact",
                                methodName: "UploadArtifactAsync",
                                pathTemplate: "$\"/v8/artifacts/{hash}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Vercel.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Vercel.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Vercel.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Vercel.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UploadArtifact",
                                methodName: "UploadArtifactAsync",
                                pathTemplate: "$\"/v8/artifacts/{hash}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Vercel.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessUploadArtifactResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Vercel.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Vercel.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UploadArtifact",
                                methodName: "UploadArtifactAsync",
                                pathTemplate: "$\"/v8/artifacts/{hash}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Vercel.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Vercel.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UploadArtifact",
                                methodName: "UploadArtifactAsync",
                                pathTemplate: "$\"/v8/artifacts/{hash}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // 
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
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
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
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
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
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
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
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
                                        __effectiveCancellationToken
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
                                            __effectiveCancellationToken
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}