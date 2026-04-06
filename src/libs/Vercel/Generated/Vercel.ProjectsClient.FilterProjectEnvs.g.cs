
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel
{
    public partial class ProjectsClient
    {
        partial void PrepareFilterProjectEnvsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string idOrName,
            ref string? gitBranch,
            ref global::Vercel.FilterProjectEnvsDecrypt? decrypt,
            ref string? source,
            ref string? customEnvironmentId,
            ref string? customEnvironmentSlug,
            ref string? teamId,
            ref string? slug);
        partial void PrepareFilterProjectEnvsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string idOrName,
            string? gitBranch,
            global::Vercel.FilterProjectEnvsDecrypt? decrypt,
            string? source,
            string? customEnvironmentId,
            string? customEnvironmentSlug,
            string? teamId,
            string? slug);
        partial void ProcessFilterProjectEnvsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFilterProjectEnvsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve the environment variables of a project by id or name<br/>
        /// Retrieve the environment variables for a given project by passing either the project `id` or `name` in the URL.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name<br/>
        /// Example: prj_XLKmu1DyR1eY7zq8UgeRKbA7yVLA
        /// </param>
        /// <param name="gitBranch">
        /// If defined, the git branch of the environment variable to filter the results (must have target=preview)<br/>
        /// Example: feature-1
        /// </param>
        /// <param name="decrypt">
        /// If true, the environment variable value will be decrypted<br/>
        /// Example: true
        /// </param>
        /// <param name="source">
        /// The source that is calling the endpoint.<br/>
        /// Example: vercel-cli:pull
        /// </param>
        /// <param name="customEnvironmentId">
        /// The unique custom environment identifier within the project<br/>
        /// Example: env_123abc4567
        /// </param>
        /// <param name="customEnvironmentSlug">
        /// The custom environment slug (name) within the project<br/>
        /// Example: my-custom-env
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.FilterProjectEnvsResponseVariant1, global::Vercel.FilterProjectEnvsResponseVariant2, global::Vercel.FilterProjectEnvsResponseVariant3>> FilterProjectEnvsAsync(
            string idOrName,
            string? gitBranch = default,
            global::Vercel.FilterProjectEnvsDecrypt? decrypt = default,
            string? source = default,
            string? customEnvironmentId = default,
            string? customEnvironmentSlug = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareFilterProjectEnvsArguments(
                httpClient: HttpClient,
                idOrName: ref idOrName,
                gitBranch: ref gitBranch,
                decrypt: ref decrypt,
                source: ref source,
                customEnvironmentId: ref customEnvironmentId,
                customEnvironmentSlug: ref customEnvironmentSlug,
                teamId: ref teamId,
                slug: ref slug);

            var __pathBuilder = new global::Vercel.PathBuilder(
                path: $"/v10/projects/{idOrName}/env",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("gitBranch", gitBranch)
                .AddOptionalParameter("decrypt", decrypt?.ToValueString())
                .AddOptionalParameter("source", source)
                .AddOptionalParameter("customEnvironmentId", customEnvironmentId)
                .AddOptionalParameter("customEnvironmentSlug", customEnvironmentSlug)
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
            PrepareFilterProjectEnvsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                idOrName: idOrName,
                gitBranch: gitBranch,
                decrypt: decrypt,
                source: source,
                customEnvironmentId: customEnvironmentId,
                customEnvironmentSlug: customEnvironmentSlug,
                teamId: teamId,
                slug: slug);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFilterProjectEnvsResponse(
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
                ProcessFilterProjectEnvsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vercel.OneOf<global::Vercel.FilterProjectEnvsResponseVariant1, global::Vercel.FilterProjectEnvsResponseVariant2, global::Vercel.FilterProjectEnvsResponseVariant3>.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Vercel.OneOf<global::Vercel.FilterProjectEnvsResponseVariant1, global::Vercel.FilterProjectEnvsResponseVariant2, global::Vercel.FilterProjectEnvsResponseVariant3>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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