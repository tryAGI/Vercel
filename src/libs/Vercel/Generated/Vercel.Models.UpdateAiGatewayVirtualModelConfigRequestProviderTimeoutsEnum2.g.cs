
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum2
    {
        /// <summary>
        /// The timeout for each provider that uses a BYOK credential, keyed by provider slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok")]
        public global::System.Collections.Generic.Dictionary<string, int>? Byok { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum2" /> class.
        /// </summary>
        /// <param name="byok">
        /// The timeout for each provider that uses a BYOK credential, keyed by provider slug.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum2(
            global::System.Collections.Generic.Dictionary<string, int>? byok)
        {
            this.Byok = byok;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum2" /> class.
        /// </summary>
        public UpdateAiGatewayVirtualModelConfigRequestProviderTimeoutsEnum2()
        {
        }

    }
}