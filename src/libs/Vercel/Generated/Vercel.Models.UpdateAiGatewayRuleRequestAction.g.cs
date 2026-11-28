
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Replaces the stored action. For a rewrite rule it must contain `rewriteModel`.
    /// </summary>
    public sealed partial class UpdateAiGatewayRuleRequestAction
    {
        /// <summary>
        /// The model that serves the request, for a rewrite rule: a catalog model, or one of your virtual models as `vmc/&lt;slug&gt;`. It must exist and be active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rewriteModel")]
        public string? RewriteModel { get; set; }

        /// <summary>
        /// Why the model is denied, for a deny rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAiGatewayRuleRequestAction" /> class.
        /// </summary>
        /// <param name="rewriteModel">
        /// The model that serves the request, for a rewrite rule: a catalog model, or one of your virtual models as `vmc/&lt;slug&gt;`. It must exist and be active.
        /// </param>
        /// <param name="reason">
        /// Why the model is denied, for a deny rule.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAiGatewayRuleRequestAction(
            string? rewriteModel,
            string? reason)
        {
            this.RewriteModel = rewriteModel;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAiGatewayRuleRequestAction" /> class.
        /// </summary>
        public UpdateAiGatewayRuleRequestAction()
        {
        }

    }
}