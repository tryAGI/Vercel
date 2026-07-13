
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
        [global::System.Text.Json.Serialization.JsonPropertyName("rewriteModel")]
        public string? RewriteModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayRuleAction" /> class.
        /// </summary>
        /// <param name="rewriteModel"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayRuleAction(
            string? rewriteModel,
            string? reason)
        {
            this.RewriteModel = rewriteModel;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayRuleAction" /> class.
        /// </summary>
        public AiGatewayRuleAction()
        {
        }

    }
}