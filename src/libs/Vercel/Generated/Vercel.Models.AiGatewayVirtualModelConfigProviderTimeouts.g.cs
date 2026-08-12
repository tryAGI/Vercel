
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Per-request provider timeouts in ms, keyed by provider slug for BYOK credentials.
    /// </summary>
    public sealed partial class AiGatewayVirtualModelConfigProviderTimeouts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok")]
        public global::System.Collections.Generic.Dictionary<string, double>? Byok { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfigProviderTimeouts" /> class.
        /// </summary>
        /// <param name="byok"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayVirtualModelConfigProviderTimeouts(
            global::System.Collections.Generic.Dictionary<string, double>? byok)
        {
            this.Byok = byok;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfigProviderTimeouts" /> class.
        /// </summary>
        public AiGatewayVirtualModelConfigProviderTimeouts()
        {
        }

    }
}