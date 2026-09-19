
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Region pinned on the VMC for system-credential routing (alias/router only).
    /// </summary>
    public sealed partial class AiGatewayVirtualModelConfigInferenceRegion
    {
        /// <summary>
        /// Geo zone (e.g. "us", "eu").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geoRegion")]
        public string? GeoRegion { get; set; }

        /// <summary>
        /// Provider-specific region identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerRegion")]
        public string? ProviderRegion { get; set; }

        /// <summary>
        /// Per-provider region overrides keyed by provider slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AiGatewayVirtualModelConfigInferenceRegionProviders2?>? Providers { get; set; }

        /// <summary>
        /// Pin scope: `specific` (one provider region), `zone` (geo zone), or `global`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AiGatewayVirtualModelConfigInferenceRegionScopeJsonConverter))]
        public global::Vercel.AiGatewayVirtualModelConfigInferenceRegionScope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfigInferenceRegion" /> class.
        /// </summary>
        /// <param name="geoRegion">
        /// Geo zone (e.g. "us", "eu").
        /// </param>
        /// <param name="providerRegion">
        /// Provider-specific region identifier.
        /// </param>
        /// <param name="providers">
        /// Per-provider region overrides keyed by provider slug.
        /// </param>
        /// <param name="scope">
        /// Pin scope: `specific` (one provider region), `zone` (geo zone), or `global`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayVirtualModelConfigInferenceRegion(
            string? geoRegion,
            string? providerRegion,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AiGatewayVirtualModelConfigInferenceRegionProviders2?>? providers,
            global::Vercel.AiGatewayVirtualModelConfigInferenceRegionScope? scope)
        {
            this.GeoRegion = geoRegion;
            this.ProviderRegion = providerRegion;
            this.Providers = providers;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfigInferenceRegion" /> class.
        /// </summary>
        public AiGatewayVirtualModelConfigInferenceRegion()
        {
        }

    }
}