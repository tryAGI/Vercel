
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProviders2
    {
        /// <summary>
        /// The pin scope: `zone` (a geo zone) or `global`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScopeJsonConverter))]
        public global::Vercel.UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope? Scope { get; set; }

        /// <summary>
        /// The geo zone, for example `us` or `eu`. Required when `scope` is `zone`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geoRegion")]
        public string? GeoRegion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProviders2" /> class.
        /// </summary>
        /// <param name="scope">
        /// The pin scope: `zone` (a geo zone) or `global`.
        /// </param>
        /// <param name="geoRegion">
        /// The geo zone, for example `us` or `eu`. Required when `scope` is `zone`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProviders2(
            global::Vercel.UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope? scope,
            string? geoRegion)
        {
            this.Scope = scope;
            this.GeoRegion = geoRegion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProviders2" /> class.
        /// </summary>
        public UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProviders2()
        {
        }

    }
}