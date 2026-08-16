
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Public response shape for virtual model configs. Used so OpenAPI generation can avoid ElectroDB's recursive EntityItem types.
    /// </summary>
    public sealed partial class AiGatewayVirtualModelConfig
    {
        /// <summary>
        /// Team (owner) that owns this VMC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// Client-facing alias used as the model slug in Gateway calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualModelSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VirtualModelSlug { get; set; }

        /// <summary>
        /// Human-readable name for UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Optional description for UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether this VMC is soft-deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// UI lifecycle status: draft, active, or archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Visibility in listings: public, internal, or stealth.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        /// User id that last updated this VMC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// VMC kind: alias, relay, or router.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// For kind=relay: URL the gateway forwards requests to as a transparent proxy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseUrl")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// The concrete model-provider instance this VMC resolves to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instanceId")]
        public string? InstanceId { get; set; }

        /// <summary>
        /// Ordered list of providers to try as fallbacks on failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerOrder")]
        public global::System.Collections.Generic.IList<string>? ProviderOrder { get; set; }

        /// <summary>
        /// Restrict routing to only these providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerOnly")]
        public global::System.Collections.Generic.IList<string>? ProviderOnly { get; set; }

        /// <summary>
        /// Arbitrary per-provider AI SDK options, keyed by gateway provider slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerOptions")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AiGatewayProviderOptionBag>? ProviderOptions { get; set; }

        /// <summary>
        /// Region pinned on the VMC for system-credential routing (alias/router only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inferenceRegion")]
        public global::Vercel.AiGatewayVirtualModelConfigInferenceRegion? InferenceRegion { get; set; }

        /// <summary>
        /// Canonical model slug this VMC maps to (e.g. "creator/model"). Not used by kind=router.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelSlug")]
        public string? ModelSlug { get; set; }

        /// <summary>
        /// For kind=router: ordered candidates, model slugs or router references. Otherwise: fallback models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// For kind=router: how to order candidates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selector")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AiGatewayVirtualModelConfigSelectorJsonConverter))]
        public global::Vercel.AiGatewayVirtualModelConfigSelector? Selector { get; set; }

        /// <summary>
        /// For kind=router: capability tags a candidate must have.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires")]
        public global::System.Collections.Generic.IList<string>? Requires { get; set; }

        /// <summary>
        /// BYOK credential IDs allowed for this VMC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byokCredentialIds")]
        public global::System.Collections.Generic.IList<string>? ByokCredentialIds { get; set; }

        /// <summary>
        /// Observability tags attached to requests through this VMC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observabilityTags")]
        public global::System.Collections.Generic.IList<string>? ObservabilityTags { get; set; }

        /// <summary>
        /// Rank eligible providers by an attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AiGatewayVirtualModelConfigSortJsonConverter))]
        public global::Vercel.AiGatewayVirtualModelConfigSort? Sort { get; set; }

        /// <summary>
        /// Limit providers to those with these features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.AiGatewayVirtualModelConfigHa>? Has { get; set; }

        /// <summary>
        /// Use caching if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caching")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AiGatewayVirtualModelConfigCachingJsonConverter))]
        public global::Vercel.AiGatewayVirtualModelConfigCaching? Caching { get; set; }

        /// <summary>
        /// Service tier for providers that support it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceTier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AiGatewayVirtualModelConfigServiceTierJsonConverter))]
        public global::Vercel.AiGatewayVirtualModelConfigServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Per-request provider timeouts in ms, keyed by provider slug for BYOK credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerTimeouts")]
        public global::Vercel.AiGatewayVirtualModelConfigProviderTimeouts? ProviderTimeouts { get; set; }

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
        /// Only use providers that will not train on your prompts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disallowPromptTraining")]
        public bool? DisallowPromptTraining { get; set; }

        /// <summary>
        /// Only use fastest providers with short timeouts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AiGatewayVirtualModelConfigSpeedJsonConverter))]
        public global::Vercel.AiGatewayVirtualModelConfigSpeed? Speed { get; set; }

        /// <summary>
        /// Allow fallback from fast to standard providers on failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowFallbackFromFast")]
        public bool? AllowFallbackFromFast { get; set; }

        /// <summary>
        /// Creation timestamp (epoch ms).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Last update timestamp (epoch ms).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfig" /> class.
        /// </summary>
        /// <param name="ownerId">
        /// Team (owner) that owns this VMC.
        /// </param>
        /// <param name="virtualModelSlug">
        /// Client-facing alias used as the model slug in Gateway calls.
        /// </param>
        /// <param name="deleted">
        /// Whether this VMC is soft-deleted.
        /// </param>
        /// <param name="status">
        /// UI lifecycle status: draft, active, or archived.
        /// </param>
        /// <param name="kind">
        /// VMC kind: alias, relay, or router.
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp (epoch ms).
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp (epoch ms).
        /// </param>
        /// <param name="displayName">
        /// Human-readable name for UI.
        /// </param>
        /// <param name="description">
        /// Optional description for UI.
        /// </param>
        /// <param name="visibility">
        /// Visibility in listings: public, internal, or stealth.
        /// </param>
        /// <param name="updatedBy">
        /// User id that last updated this VMC.
        /// </param>
        /// <param name="baseUrl">
        /// For kind=relay: URL the gateway forwards requests to as a transparent proxy.
        /// </param>
        /// <param name="instanceId">
        /// The concrete model-provider instance this VMC resolves to.
        /// </param>
        /// <param name="providerOrder">
        /// Ordered list of providers to try as fallbacks on failure.
        /// </param>
        /// <param name="providerOnly">
        /// Restrict routing to only these providers.
        /// </param>
        /// <param name="providerOptions">
        /// Arbitrary per-provider AI SDK options, keyed by gateway provider slug.
        /// </param>
        /// <param name="inferenceRegion">
        /// Region pinned on the VMC for system-credential routing (alias/router only).
        /// </param>
        /// <param name="modelSlug">
        /// Canonical model slug this VMC maps to (e.g. "creator/model"). Not used by kind=router.
        /// </param>
        /// <param name="models">
        /// For kind=router: ordered candidates, model slugs or router references. Otherwise: fallback models.
        /// </param>
        /// <param name="selector">
        /// For kind=router: how to order candidates.
        /// </param>
        /// <param name="requires">
        /// For kind=router: capability tags a candidate must have.
        /// </param>
        /// <param name="byokCredentialIds">
        /// BYOK credential IDs allowed for this VMC.
        /// </param>
        /// <param name="observabilityTags">
        /// Observability tags attached to requests through this VMC.
        /// </param>
        /// <param name="sort">
        /// Rank eligible providers by an attribute.
        /// </param>
        /// <param name="has">
        /// Limit providers to those with these features.
        /// </param>
        /// <param name="caching">
        /// Use caching if available.
        /// </param>
        /// <param name="serviceTier">
        /// Service tier for providers that support it.
        /// </param>
        /// <param name="providerTimeouts">
        /// Per-request provider timeouts in ms, keyed by provider slug for BYOK credentials.
        /// </param>
        /// <param name="zeroDataRetention">
        /// Only use providers with zero data retention.
        /// </param>
        /// <param name="hipaaCompliant">
        /// Only use HIPAA-compliant providers.
        /// </param>
        /// <param name="disallowPromptTraining">
        /// Only use providers that will not train on your prompts.
        /// </param>
        /// <param name="speed">
        /// Only use fastest providers with short timeouts.
        /// </param>
        /// <param name="allowFallbackFromFast">
        /// Allow fallback from fast to standard providers on failure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayVirtualModelConfig(
            string ownerId,
            string virtualModelSlug,
            bool deleted,
            string status,
            string kind,
            double createdAt,
            double updatedAt,
            string? displayName,
            string? description,
            string? visibility,
            string? updatedBy,
            string? baseUrl,
            string? instanceId,
            global::System.Collections.Generic.IList<string>? providerOrder,
            global::System.Collections.Generic.IList<string>? providerOnly,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AiGatewayProviderOptionBag>? providerOptions,
            global::Vercel.AiGatewayVirtualModelConfigInferenceRegion? inferenceRegion,
            string? modelSlug,
            global::System.Collections.Generic.IList<string>? models,
            global::Vercel.AiGatewayVirtualModelConfigSelector? selector,
            global::System.Collections.Generic.IList<string>? requires,
            global::System.Collections.Generic.IList<string>? byokCredentialIds,
            global::System.Collections.Generic.IList<string>? observabilityTags,
            global::Vercel.AiGatewayVirtualModelConfigSort? sort,
            global::System.Collections.Generic.IList<global::Vercel.AiGatewayVirtualModelConfigHa>? has,
            global::Vercel.AiGatewayVirtualModelConfigCaching? caching,
            global::Vercel.AiGatewayVirtualModelConfigServiceTier? serviceTier,
            global::Vercel.AiGatewayVirtualModelConfigProviderTimeouts? providerTimeouts,
            bool? zeroDataRetention,
            bool? hipaaCompliant,
            bool? disallowPromptTraining,
            global::Vercel.AiGatewayVirtualModelConfigSpeed? speed,
            bool? allowFallbackFromFast)
        {
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.VirtualModelSlug = virtualModelSlug ?? throw new global::System.ArgumentNullException(nameof(virtualModelSlug));
            this.DisplayName = displayName;
            this.Description = description;
            this.Deleted = deleted;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Visibility = visibility;
            this.UpdatedBy = updatedBy;
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.BaseUrl = baseUrl;
            this.InstanceId = instanceId;
            this.ProviderOrder = providerOrder;
            this.ProviderOnly = providerOnly;
            this.ProviderOptions = providerOptions;
            this.InferenceRegion = inferenceRegion;
            this.ModelSlug = modelSlug;
            this.Models = models;
            this.Selector = selector;
            this.Requires = requires;
            this.ByokCredentialIds = byokCredentialIds;
            this.ObservabilityTags = observabilityTags;
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
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfig" /> class.
        /// </summary>
        public AiGatewayVirtualModelConfig()
        {
        }

    }
}