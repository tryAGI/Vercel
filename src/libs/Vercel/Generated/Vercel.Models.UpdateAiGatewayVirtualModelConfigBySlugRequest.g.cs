
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateAiGatewayVirtualModelConfigBySlugRequest
    {
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
        /// Set to `false` to restore a deleted virtual model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Provider-specific options, keyed by provider slug. The slug of one of your team's private providers is also valid. `null` removes the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerOptions")]
        public global::System.Collections.Generic.Dictionary<string, object>? ProviderOptions { get; set; }

        /// <summary>
        /// The BYOK credentials that this virtual model can use. `null` removes the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byokCredentialIds")]
        public global::System.Collections.Generic.IList<string>? ByokCredentialIds { get; set; }

        /// <summary>
        /// The region that requests are pinned to. `null` removes the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inferenceRegion")]
        public global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegion? InferenceRegion { get; set; }

        /// <summary>
        /// Rank eligible providers by an attribute. `@default` ignores the value from the inference request. `null` removes the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateAiGatewayVirtualModelConfigBySlugRequestSortJsonConverter))]
        public global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestSort? Sort { get; set; }

        /// <summary>
        /// Limit providers to those with these features. `null` removes the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestHa>? Has { get; set; }

        /// <summary>
        /// Use caching if available. `@default` ignores the value from the inference request. `null` removes the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caching")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateAiGatewayVirtualModelConfigBySlugRequestCachingJsonConverter))]
        public global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestCaching? Caching { get; set; }

        /// <summary>
        /// The service tier for providers that support it. `@default` ignores the value from the inference request. `null` removes the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceTier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTierJsonConverter))]
        public global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Provider timeouts in milliseconds. `@default` ignores the value from the inference request. `null` removes the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerTimeouts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestProviderTimeoutsEnum?, global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestProviderTimeoutsEnum2>))]
        public global::Vercel.OneOf<global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestProviderTimeoutsEnum?, global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestProviderTimeoutsEnum2>? ProviderTimeouts { get; set; }

        /// <summary>
        /// Only use providers with zero data retention. `null` removes the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zeroDataRetention")]
        public bool? ZeroDataRetention { get; set; }

        /// <summary>
        /// Only use HIPAA-compliant providers. `null` removes the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hipaaCompliant")]
        public bool? HipaaCompliant { get; set; }

        /// <summary>
        /// Only use providers that do not train on prompts. `null` removes the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disallowPromptTraining")]
        public bool? DisallowPromptTraining { get; set; }

        /// <summary>
        /// Only use the fastest providers, with short timeouts. `null` removes the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateAiGatewayVirtualModelConfigBySlugRequestSpeedJsonConverter))]
        public global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestSpeed? Speed { get; set; }

        /// <summary>
        /// Allow fallback from fast to standard providers on failure. `null` removes the stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowFallbackFromFast")]
        public bool? AllowFallbackFromFast { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAiGatewayVirtualModelConfigBySlugRequest" /> class.
        /// </summary>
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
        /// <param name="deleted">
        /// Set to `false` to restore a deleted virtual model.
        /// </param>
        /// <param name="providerOptions">
        /// Provider-specific options, keyed by provider slug. The slug of one of your team's private providers is also valid. `null` removes the stored value.
        /// </param>
        /// <param name="byokCredentialIds">
        /// The BYOK credentials that this virtual model can use. `null` removes the stored value.
        /// </param>
        /// <param name="inferenceRegion">
        /// The region that requests are pinned to. `null` removes the stored value.
        /// </param>
        /// <param name="sort">
        /// Rank eligible providers by an attribute. `@default` ignores the value from the inference request. `null` removes the stored value.
        /// </param>
        /// <param name="has">
        /// Limit providers to those with these features. `null` removes the stored value.
        /// </param>
        /// <param name="caching">
        /// Use caching if available. `@default` ignores the value from the inference request. `null` removes the stored value.
        /// </param>
        /// <param name="serviceTier">
        /// The service tier for providers that support it. `@default` ignores the value from the inference request. `null` removes the stored value.
        /// </param>
        /// <param name="providerTimeouts">
        /// Provider timeouts in milliseconds. `@default` ignores the value from the inference request. `null` removes the stored value.
        /// </param>
        /// <param name="zeroDataRetention">
        /// Only use providers with zero data retention. `null` removes the stored value.
        /// </param>
        /// <param name="hipaaCompliant">
        /// Only use HIPAA-compliant providers. `null` removes the stored value.
        /// </param>
        /// <param name="disallowPromptTraining">
        /// Only use providers that do not train on prompts. `null` removes the stored value.
        /// </param>
        /// <param name="speed">
        /// Only use the fastest providers, with short timeouts. `null` removes the stored value.
        /// </param>
        /// <param name="allowFallbackFromFast">
        /// Allow fallback from fast to standard providers on failure. `null` removes the stored value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAiGatewayVirtualModelConfigBySlugRequest(
            string? displayName,
            string? description,
            string? status,
            string? modelSlug,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<string, global::Vercel.AutoSDKShared288a9d17673d8a52Item2>>? models,
            global::System.Collections.Generic.IList<string>? providerOrder,
            global::System.Collections.Generic.IList<string>? providerOnly,
            global::System.Collections.Generic.IList<string>? observabilityTags,
            bool? deleted,
            global::System.Collections.Generic.Dictionary<string, object>? providerOptions,
            global::System.Collections.Generic.IList<string>? byokCredentialIds,
            global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegion? inferenceRegion,
            global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestSort? sort,
            global::System.Collections.Generic.IList<global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestHa>? has,
            global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestCaching? caching,
            global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTier? serviceTier,
            global::Vercel.OneOf<global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestProviderTimeoutsEnum?, global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestProviderTimeoutsEnum2>? providerTimeouts,
            bool? zeroDataRetention,
            bool? hipaaCompliant,
            bool? disallowPromptTraining,
            global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestSpeed? speed,
            bool? allowFallbackFromFast)
        {
            this.DisplayName = displayName;
            this.Description = description;
            this.Status = status;
            this.ModelSlug = modelSlug;
            this.Models = models;
            this.ProviderOrder = providerOrder;
            this.ProviderOnly = providerOnly;
            this.ObservabilityTags = observabilityTags;
            this.Deleted = deleted;
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
        /// Initializes a new instance of the <see cref="UpdateAiGatewayVirtualModelConfigBySlugRequest" /> class.
        /// </summary>
        public UpdateAiGatewayVirtualModelConfigBySlugRequest()
        {
        }

    }
}