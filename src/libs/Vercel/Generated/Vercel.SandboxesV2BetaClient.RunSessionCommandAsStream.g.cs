
#nullable enable

namespace Vercel
{
    public partial class SandboxesV2BetaClient
    {
        partial void PrepareRunSessionCommandAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string sessionId,
            ref string? teamId,
            ref string? slug,
            global::Vercel.RunSessionCommandRequest request);
        partial void PrepareRunSessionCommandAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string sessionId,
            string? teamId,
            string? slug,
            global::Vercel.RunSessionCommandRequest request);
        partial void ProcessRunSessionCommandAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Execute a command<br/>
        /// Executes a shell command inside a running session. The command runs asynchronously and returns immediately with a command ID that can be used to track its progress and retrieve its output. Optionally, use the `wait` parameter to stream the command status until completion.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session in which to execute the command.<br/>
        /// Example: sbx_abc123
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
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Vercel.RunSessionCommandResponse2> RunSessionCommandAsStreamAsync(
            string sessionId,

            global::Vercel.RunSessionCommandRequest request,
            string? teamId = default,
            string? slug = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRunSessionCommandAsStreamArguments(
                httpClient: HttpClient,
                sessionId: ref sessionId,
                teamId: ref teamId,
                slug: ref slug,
                request: request);

            var __pathBuilder = new global::Vercel.PathBuilder(
                path: $"/v2/sandboxes/sessions/{sessionId}/cmd",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
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
            PrepareRunSessionCommandAsStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                sessionId: sessionId,
                teamId: teamId,
                slug: slug,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRunSessionCommandAsStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
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

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);
            using var __reader = new global::System.IO.StreamReader(__stream);

            while (!__reader.EndOfStream && !cancellationToken.IsCancellationRequested)
            {
                var __content = await __reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                if (global::System.String.IsNullOrWhiteSpace(__content))
                {
                    continue;
                }

                var __streamedResponse = global::Vercel.RunSessionCommandResponse2.FromJson(__content, JsonSerializerOptions) ??
                                       throw new global::Vercel.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
            }
        }
        /// <summary>
        /// Execute a command<br/>
        /// Executes a shell command inside a running session. The command runs asynchronously and returns immediately with a command ID that can be used to track its progress and retrieve its output. Optionally, use the `wait` parameter to stream the command status until completion.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session in which to execute the command.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="command">
        /// The executable or shell command to run. This is the program name without arguments.<br/>
        /// Example: npm
        /// </param>
        /// <param name="args">
        /// Arguments to pass to the command. Each argument should be a separate array element.<br/>
        /// Example: [install, --save, lodash]
        /// </param>
        /// <param name="cwd">
        /// The working directory in which to execute the command. Defaults to the sandbox home directory if not specified.<br/>
        /// Example: /home/vercel-sandbox
        /// </param>
        /// <param name="env">
        /// Additional environment variables to set for this command. These are merged with the sandbox environment.<br/>
        /// Default Value: {}<br/>
        /// Example: {"NODE_ENV":"production","DEBUG":"true"}
        /// </param>
        /// <param name="sudo">
        /// Execute the command with root (superuser) privileges.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="wait">
        /// If true, returns an ND-JSON stream that emits the command status when started and again when finished. Useful for synchronously waiting for command completion.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Vercel.RunSessionCommandResponse2> RunSessionCommandAsStreamAsync(
            string sessionId,
            string command,
            string? teamId = default,
            string? slug = default,
            global::System.Collections.Generic.IList<string>? args = default,
            string? cwd = default,
            global::System.Collections.Generic.Dictionary<string, string>? env = default,
            bool? sudo = default,
            bool? wait = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vercel.RunSessionCommandRequest
            {
                Command = command,
                Args = args,
                Cwd = cwd,
                Env = env,
                Sudo = sudo,
                Wait = wait,
            };

            var __enumerable = RunSessionCommandAsStreamAsync(
                sessionId: sessionId,
                teamId: teamId,
                slug: slug,
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}