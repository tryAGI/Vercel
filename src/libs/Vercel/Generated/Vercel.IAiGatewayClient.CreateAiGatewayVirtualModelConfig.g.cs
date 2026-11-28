#nullable enable

namespace Vercel
{
    public partial interface IAiGatewayClient
    {
        /// <summary>
        /// Create virtual model config<br/>
        /// Create a virtual model config (VMC)
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Vercel.AiGatewayVirtualModelConfig> CreateAiGatewayVirtualModelConfigAsync(

            global::Vercel.CreateAiGatewayVirtualModelConfigRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create virtual model config<br/>
        /// Create a virtual model config (VMC)
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.AiGatewayVirtualModelConfig>> CreateAiGatewayVirtualModelConfigAsResponseAsync(

            global::Vercel.CreateAiGatewayVirtualModelConfigRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create virtual model config<br/>
        /// Create a virtual model config (VMC)
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="virtualModelSlug">
        /// The slug of the virtual model. Requests name it as `vmc/&lt;slug&gt;`. `list` is reserved.
        /// </param>
        /// <param name="displayName">
        /// The name shown in the UI.
        /// </param>
        /// <param name="description"></param>
        /// <param name="status">
        /// The lifecycle status: `draft`, `active`, or `archived`. Any value other than `active` stops it serving requests. Defaults to `active`.
        /// </param>
        /// <param name="modelSlug">
        /// The model that the virtual model resolves to: a catalog model such as `openai/gpt-4o-mini`, or one of your team's private models as `private/&lt;slug&gt;`. Required on create.
        /// </param>
        /// <param name="models">
        /// The ordered fallback models, optionally led by one conditional `{ model, when }` entry.
        /// </param>
        /// <param name="providerOrder">
        /// The providers to try, in order.
        /// </param>
        /// <param name="providerOnly">
        /// Restrict routing to these providers.
        /// </param>
        /// <param name="observabilityTags">
        /// Observability tags attached to requests through this virtual model.
        /// </param>
        /// <param name="providerOptions">
        /// Provider-specific options, keyed by provider slug. The slug of one of your team's private providers is also valid.
        /// </param>
        /// <param name="byokCredentialIds">
        /// The BYOK credentials that this virtual model can use.
        /// </param>
        /// <param name="inferenceRegion">
        /// The region that requests are pinned to.
        /// </param>
        /// <param name="sort">
        /// Rank eligible providers by an attribute. `@default` ignores the value from the inference request.
        /// </param>
        /// <param name="has">
        /// Limit providers to those with these features.
        /// </param>
        /// <param name="caching">
        /// Use caching if available. `@default` ignores the value from the inference request.
        /// </param>
        /// <param name="serviceTier">
        /// The service tier for providers that support it. `@default` ignores the value from the inference request.
        /// </param>
        /// <param name="providerTimeouts">
        /// Provider timeouts in milliseconds. `@default` ignores the value from the inference request.
        /// </param>
        /// <param name="zeroDataRetention">
        /// Only use providers with zero data retention.
        /// </param>
        /// <param name="hipaaCompliant">
        /// Only use HIPAA-compliant providers.
        /// </param>
        /// <param name="disallowPromptTraining">
        /// Only use providers that do not train on prompts.
        /// </param>
        /// <param name="speed">
        /// Only use the fastest providers, with short timeouts.
        /// </param>
        /// <param name="allowFallbackFromFast">
        /// Allow fallback from fast to standard providers on failure.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AiGatewayVirtualModelConfig> CreateAiGatewayVirtualModelConfigAsync(
            string virtualModelSlug,
            string? teamId = default,
            string? slug = default,
            string? displayName = default,
            string? description = default,
            string? status = default,
            string? modelSlug = default,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<string, global::Vercel.AutoSDKShared288a9d17673d8a52Item2>>? models = default,
            global::System.Collections.Generic.IList<string>? providerOrder = default,
            global::System.Collections.Generic.IList<string>? providerOnly = default,
            global::System.Collections.Generic.IList<string>? observabilityTags = default,
            global::System.Collections.Generic.Dictionary<string, object>? providerOptions = default,
            global::System.Collections.Generic.IList<string>? byokCredentialIds = default,
            global::Vercel.CreateAiGatewayVirtualModelConfigRequestInferenceRegion? inferenceRegion = default,
            global::Vercel.CreateAiGatewayVirtualModelConfigRequestSort? sort = default,
            global::System.Collections.Generic.IList<global::Vercel.CreateAiGatewayVirtualModelConfigRequestHa>? has = default,
            global::Vercel.CreateAiGatewayVirtualModelConfigRequestCaching? caching = default,
            global::Vercel.CreateAiGatewayVirtualModelConfigRequestServiceTier? serviceTier = default,
            global::Vercel.OneOf<global::Vercel.CreateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum?, global::Vercel.CreateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum2>? providerTimeouts = default,
            bool? zeroDataRetention = default,
            bool? hipaaCompliant = default,
            bool? disallowPromptTraining = default,
            global::Vercel.CreateAiGatewayVirtualModelConfigRequestSpeed? speed = default,
            bool? allowFallbackFromFast = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}