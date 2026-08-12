
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Per-provider region overrides keyed by provider slug.
    /// </summary>
    public sealed partial class AiGatewayVirtualModelConfigInferenceRegionProviders2
    {
        /// <summary>
        /// Pin scope: `specific` (one provider region), `zone` (geo zone), or `global`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AiGatewayVirtualModelConfigInferenceRegionProvidersScopeJsonConverter))]
        public global::Vercel.AiGatewayVirtualModelConfigInferenceRegionProvidersScope? Scope { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfigInferenceRegionProviders2" /> class.
        /// </summary>
        /// <param name="scope">
        /// Pin scope: `specific` (one provider region), `zone` (geo zone), or `global`.
        /// </param>
        /// <param name="geoRegion">
        /// Geo zone (e.g. "us", "eu").
        /// </param>
        /// <param name="providerRegion">
        /// Provider-specific region identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayVirtualModelConfigInferenceRegionProviders2(
            global::Vercel.AiGatewayVirtualModelConfigInferenceRegionProvidersScope? scope,
            string? geoRegion,
            string? providerRegion)
        {
            this.Scope = scope;
            this.GeoRegion = geoRegion;
            this.ProviderRegion = providerRegion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfigInferenceRegionProviders2" /> class.
        /// </summary>
        public AiGatewayVirtualModelConfigInferenceRegionProviders2()
        {
        }

    }
}