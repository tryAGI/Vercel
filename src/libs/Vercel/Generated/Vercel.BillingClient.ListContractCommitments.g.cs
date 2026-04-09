
#nullable enable

namespace Vercel
{
    public partial class BillingClient
    {


        private static readonly global::Vercel.EndPointSecurityRequirement s_ListContractCommitmentsSecurityRequirement0 =
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
        private static readonly global::Vercel.EndPointSecurityRequirement[] s_ListContractCommitmentsSecurityRequirements =
            new global::Vercel.EndPointSecurityRequirement[]
            {                s_ListContractCommitmentsSecurityRequirement0,
            };
        partial void PrepareListContractCommitmentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? teamId,
            ref string? slug);
        partial void PrepareListContractCommitmentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? teamId,
            string? slug);
        partial void ProcessListContractCommitmentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// List FOCUS contract commitments<br/>
        /// Returns commitment allocations per contract period in FOCUS v1.3 JSONL format for a specified Vercel team. The response is streamed as newline-delimited JSON (JSONL). This endpoint is only applicable to Enterprise Vercel customers. An empty response is returned for non-Enterprise (Pro/Flex) customers.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Vercel.ListContractCommitmentsResponse> ListContractCommitmentsAsync(
            string? teamId = default,
            string? slug = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListContractCommitmentsArguments(
                httpClient: HttpClient,
                teamId: ref teamId,
                slug: ref slug);


            var __authorizations = global::Vercel.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListContractCommitmentsSecurityRequirements,
                operationName: "ListContractCommitmentsAsync");

            var __pathBuilder = new global::Vercel.PathBuilder(
                path: "/v1/billing/contract-commitments",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
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
            PrepareListContractCommitmentsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                teamId: teamId,
                slug: slug);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListContractCommitmentsResponse(
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

                var __streamedResponse = global::Vercel.ListContractCommitmentsResponse.FromJson(__content, JsonSerializerContext) ??
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
    }
}