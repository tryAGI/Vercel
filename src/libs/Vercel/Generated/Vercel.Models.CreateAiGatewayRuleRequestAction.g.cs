
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Required when `type` is `rewrite`.
    /// </summary>
    public sealed partial class CreateAiGatewayRuleRequestAction
    {
        /// <summary>
        /// The model that serves the request: a catalog model, or one of your virtual models as `vmc/&lt;slug&gt;`. It must exist and be active. Required when `type` is `rewrite`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rewriteModel")]
        public string? RewriteModel { get; set; }

        /// <summary>
        /// Why the model is denied. Used when `type` is `deny`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiGatewayRuleRequestAction" /> class.
        /// </summary>
        /// <param name="rewriteModel">
        /// The model that serves the request: a catalog model, or one of your virtual models as `vmc/&lt;slug&gt;`. It must exist and be active. Required when `type` is `rewrite`.
        /// </param>
        /// <param name="reason">
        /// Why the model is denied. Used when `type` is `deny`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAiGatewayRuleRequestAction(
            string? rewriteModel,
            string? reason)
        {
            this.RewriteModel = rewriteModel;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiGatewayRuleRequestAction" /> class.
        /// </summary>
        public CreateAiGatewayRuleRequestAction()
        {
        }

    }
}