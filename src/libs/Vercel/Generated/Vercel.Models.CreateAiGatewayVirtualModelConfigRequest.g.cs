
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAiGatewayVirtualModelConfigRequest
    {
        /// <summary>
        /// The slug of the virtual model. Requests name it as `vmc/&lt;slug&gt;`. `list` is reserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualModelSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VirtualModelSlug { get; set; }

        /// <summary>
        /// The name shown in the UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The lifecycle status: `draft`, `active`, or `archived`. Any value other than `active` stops it serving requests. Defaults to `active`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The model that the virtual model resolves to: a catalog model such as `openai/gpt-4o-mini`, or one of your team's private models as `private/&lt;slug&gt;`. Required on create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelSlug")]
        public string? ModelSlug { get; set; }

        /// <summary>
        /// The ordered fallback models, optionally led by one conditional `{ model, when }` entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<string, global::Vercel.AutoSDKShared288a9d17673d8a52Item2>>? Models { get; set; }

        /// <summary>
        /// The providers to try, in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerOrder")]
        public global::System.Collections.Generic.IList<string>? ProviderOrder { get; set; }

        /// <summary>
        /// Restrict routing to these providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerOnly")]
        public global::System.Collections.Generic.IList<string>? ProviderOnly { get; set; }

        /// <summary>
        /// Observability tags attached to requests through this virtual model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observabilityTags")]
        public global::System.Collections.Generic.IList<string>? ObservabilityTags { get; set; }

        /// <summary>
        /// Provider-specific options, keyed by provider slug. The slug of one of your team's private providers is also valid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerOptions")]
        public global::System.Collections.Generic.Dictionary<string, object>? ProviderOptions { get; set; }

        /// <summary>
        /// The BYOK credentials that this virtual model can use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byokCredentialIds")]
        public global::System.Collections.Generic.IList<string>? ByokCredentialIds { get; set; }

        /// <summary>
        /// The region that requests are pinned to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inferenceRegion")]
        public global::Vercel.CreateAiGatewayVirtualModelConfigRequestInferenceRegion? InferenceRegion { get; set; }

        /// <summary>
        /// Rank eligible providers by an attribute. `@default` ignores the value from the inference request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateAiGatewayVirtualModelConfigRequestSortJsonConverter))]
        public global::Vercel.CreateAiGatewayVirtualModelConfigRequestSort? Sort { get; set; }

        /// <summary>
        /// Limit providers to those with these features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateAiGatewayVirtualModelConfigRequestHa>? Has { get; set; }

        /// <summary>
        /// Use caching if available. `@default` ignores the value from the inference request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caching")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateAiGatewayVirtualModelConfigRequestCachingJsonConverter))]
        public global::Vercel.CreateAiGatewayVirtualModelConfigRequestCaching? Caching { get; set; }

        /// <summary>
        /// The service tier for providers that support it. `@default` ignores the value from the inference request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceTier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateAiGatewayVirtualModelConfigRequestServiceTierJsonConverter))]
        public global::Vercel.CreateAiGatewayVirtualModelConfigRequestServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Provider timeouts in milliseconds. `@default` ignores the value from the inference request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerTimeouts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum?, global::Vercel.CreateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum2>))]
        public global::Vercel.OneOf<global::Vercel.CreateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum?, global::Vercel.CreateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum2>? ProviderTimeouts { get; set; }

        /// <summary>
        /// Only use providers with zero data retention.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zeroDataRetention")]
        public bool? ZeroDataRetention { get; set; }

        /// <summary>
        /// Only use HIPAA-compliant providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hipaaCompliant")]
        public bool? HipaaCompliant { get; set; }

        /// <summary>
        /// Only use providers that do not train on prompts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disallowPromptTraining")]
        public bool? DisallowPromptTraining { get; set; }

        /// <summary>
        /// Only use the fastest providers, with short timeouts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateAiGatewayVirtualModelConfigRequestSpeedJsonConverter))]
        public global::Vercel.CreateAiGatewayVirtualModelConfigRequestSpeed? Speed { get; set; }

        /// <summary>
        /// Allow fallback from fast to standard providers on failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowFallbackFromFast")]
        public bool? AllowFallbackFromFast { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiGatewayVirtualModelConfigRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAiGatewayVirtualModelConfigRequest(
            string virtualModelSlug,
            string? displayName,
            string? description,
            string? status,
            string? modelSlug,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<string, global::Vercel.AutoSDKShared288a9d17673d8a52Item2>>? models,
            global::System.Collections.Generic.IList<string>? providerOrder,
            global::System.Collections.Generic.IList<string>? providerOnly,
            global::System.Collections.Generic.IList<string>? observabilityTags,
            global::System.Collections.Generic.Dictionary<string, object>? providerOptions,
            global::System.Collections.Generic.IList<string>? byokCredentialIds,
            global::Vercel.CreateAiGatewayVirtualModelConfigRequestInferenceRegion? inferenceRegion,
            global::Vercel.CreateAiGatewayVirtualModelConfigRequestSort? sort,
            global::System.Collections.Generic.IList<global::Vercel.CreateAiGatewayVirtualModelConfigRequestHa>? has,
            global::Vercel.CreateAiGatewayVirtualModelConfigRequestCaching? caching,
            global::Vercel.CreateAiGatewayVirtualModelConfigRequestServiceTier? serviceTier,
            global::Vercel.OneOf<global::Vercel.CreateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum?, global::Vercel.CreateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum2>? providerTimeouts,
            bool? zeroDataRetention,
            bool? hipaaCompliant,
            bool? disallowPromptTraining,
            global::Vercel.CreateAiGatewayVirtualModelConfigRequestSpeed? speed,
            bool? allowFallbackFromFast)
        {
            this.VirtualModelSlug = virtualModelSlug ?? throw new global::System.ArgumentNullException(nameof(virtualModelSlug));
            this.DisplayName = displayName;
            this.Description = description;
            this.Status = status;
            this.ModelSlug = modelSlug;
            this.Models = models;
            this.ProviderOrder = providerOrder;
            this.ProviderOnly = providerOnly;
            this.ObservabilityTags = observabilityTags;
            this.ProviderOptions = providerOptions;
            this.ByokCredentialIds = byokCredentialIds;
            this.InferenceRegion = inferenceRegion;
            this.Sort = sort;
            this.Has = has;
            this.Caching = caching;
            this.ServiceTier = serviceTier;
            this.ProviderTimeouts = providerTimeouts;
            this.ZeroDataRetention = zeroDataRetention;
            this.HipaaCompliant = hipaaCompliant;
            this.DisallowPromptTraining = disallowPromptTraining;
            this.Speed = speed;
            this.AllowFallbackFromFast = allowFallbackFromFast;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiGatewayVirtualModelConfigRequest" /> class.
        /// </summary>
        public CreateAiGatewayVirtualModelConfigRequest()
        {
        }

    }
}