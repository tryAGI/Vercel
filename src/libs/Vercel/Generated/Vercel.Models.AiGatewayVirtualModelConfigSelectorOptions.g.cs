
#nullable enable

namespace Vercel
{
    /// <summary>
    /// For kind=router: option slices keyed by selector name; each selector owns its slice's shape.
    /// </summary>
    public sealed partial class AiGatewayVirtualModelConfigSelectorOptions
    {
        /// <summary>
        /// For kind=router: option slices keyed by selector name; each selector owns its slice's shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public global::Vercel.AiGatewayRouterSelectorOptionBag? Cost { get; set; }

        /// <summary>
        /// For kind=router: option slices keyed by selector name; each selector owns its slice's shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tps")]
        public global::Vercel.AiGatewayRouterSelectorOptionBag? Tps { get; set; }

        /// <summary>
        /// For kind=router: option slices keyed by selector name; each selector owns its slice's shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttft")]
        public global::Vercel.AiGatewayRouterSelectorOptionBag? Ttft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfigSelectorOptions" /> class.
        /// </summary>
        /// <param name="cost">
        /// For kind=router: option slices keyed by selector name; each selector owns its slice's shape.
        /// </param>
        /// <param name="tps">
        /// For kind=router: option slices keyed by selector name; each selector owns its slice's shape.
        /// </param>
        /// <param name="ttft">
        /// For kind=router: option slices keyed by selector name; each selector owns its slice's shape.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayVirtualModelConfigSelectorOptions(
            global::Vercel.AiGatewayRouterSelectorOptionBag? cost,
            global::Vercel.AiGatewayRouterSelectorOptionBag? tps,
            global::Vercel.AiGatewayRouterSelectorOptionBag? ttft)
        {
            this.Cost = cost;
            this.Tps = tps;
            this.Ttft = ttft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfigSelectorOptions" /> class.
        /// </summary>
        public AiGatewayVirtualModelConfigSelectorOptions()
        {
        }

    }
}