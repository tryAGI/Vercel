
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiGatewayRuleAction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rewriteModel")]
        public string? RewriteModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayRuleAction" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="rewriteModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayRuleAction(
            string? reason,
            string? rewriteModel)
        {
            this.Reason = reason;
            this.RewriteModel = rewriteModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayRuleAction" /> class.
        /// </summary>
        public AiGatewayRuleAction()
        {
        }

    }
}