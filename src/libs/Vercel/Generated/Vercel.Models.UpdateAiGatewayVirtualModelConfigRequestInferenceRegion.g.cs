
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The region that requests are pinned to. `null` removes the stored value.
    /// </summary>
    public sealed partial class UpdateAiGatewayVirtualModelConfigRequestInferenceRegion
    {
        /// <summary>
        /// The pin scope: `zone` (a geo zone) or `global`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateAiGatewayVirtualModelConfigRequestInferenceRegionScopeJsonConverter))]
        public global::Vercel.UpdateAiGatewayVirtualModelConfigRequestInferenceRegionScope? Scope { get; set; }

        /// <summary>
        /// The geo zone, for example `us` or `eu`. Required when `scope` is `zone`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geoRegion")]
        public string? GeoRegion { get; set; }

        /// <summary>
        /// Region overrides for each provider, keyed by provider slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProviders2?>? Providers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAiGatewayVirtualModelConfigRequestInferenceRegion" /> class.
        /// </summary>
        /// <param name="scope">
        /// The pin scope: `zone` (a geo zone) or `global`.
        /// </param>
        /// <param name="geoRegion">
        /// The geo zone, for example `us` or `eu`. Required when `scope` is `zone`.
        /// </param>
        /// <param name="providers">
        /// Region overrides for each provider, keyed by provider slug.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAiGatewayVirtualModelConfigRequestInferenceRegion(
            global::Vercel.UpdateAiGatewayVirtualModelConfigRequestInferenceRegionScope? scope,
            string? geoRegion,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProviders2?>? providers)
        {
            this.Scope = scope;
            this.GeoRegion = geoRegion;
            this.Providers = providers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAiGatewayVirtualModelConfigRequestInferenceRegion" /> class.
        /// </summary>
        public UpdateAiGatewayVirtualModelConfigRequestInferenceRegion()
        {
        }

    }
}