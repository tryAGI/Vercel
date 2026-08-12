
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiGatewayVirtualModelConfigList
    {
        /// <summary>
        /// The page of VMCs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualModelConfigs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AiGatewayVirtualModelConfig> VirtualModelConfigs { get; set; }

        /// <summary>
        /// Cursor for the next page, or null when no more pages remain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfigList" /> class.
        /// </summary>
        /// <param name="virtualModelConfigs">
        /// The page of VMCs.
        /// </param>
        /// <param name="cursor">
        /// Cursor for the next page, or null when no more pages remain.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayVirtualModelConfigList(
            global::System.Collections.Generic.IList<global::Vercel.AiGatewayVirtualModelConfig> virtualModelConfigs,
            string? cursor)
        {
            this.VirtualModelConfigs = virtualModelConfigs ?? throw new global::System.ArgumentNullException(nameof(virtualModelConfigs));
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfigList" /> class.
        /// </summary>
        public AiGatewayVirtualModelConfigList()
        {
        }

    }
}