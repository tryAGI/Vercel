
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiGatewayRouterList
    {
        /// <summary>
        /// Active and archived router configurations owned by the authenticated team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AiGatewayVirtualModelConfig> Routers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayRouterList" /> class.
        /// </summary>
        /// <param name="routers">
        /// Active and archived router configurations owned by the authenticated team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayRouterList(
            global::System.Collections.Generic.IList<global::Vercel.AiGatewayVirtualModelConfig> routers)
        {
            this.Routers = routers ?? throw new global::System.ArgumentNullException(nameof(routers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayRouterList" /> class.
        /// </summary>
        public AiGatewayRouterList()
        {
        }

    }
}