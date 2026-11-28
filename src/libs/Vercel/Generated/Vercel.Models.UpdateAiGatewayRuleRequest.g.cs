
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateAiGatewayRuleRequest
    {
        /// <summary>
        /// The ID of the rule to update. Send at least one of `enabled`, `description`, or `action` with it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RuleId { get; set; }

        /// <summary>
        /// Whether the rule is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// A free-text note about the rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Replaces the stored action. For a rewrite rule it must contain `rewriteModel`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::Vercel.UpdateAiGatewayRuleRequestAction? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAiGatewayRuleRequest" /> class.
        /// </summary>
        /// <param name="ruleId">
        /// The ID of the rule to update. Send at least one of `enabled`, `description`, or `action` with it.
        /// </param>
        /// <param name="enabled">
        /// Whether the rule is enabled.
        /// </param>
        /// <param name="description">
        /// A free-text note about the rule.
        /// </param>
        /// <param name="action">
        /// Replaces the stored action. For a rewrite rule it must contain `rewriteModel`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAiGatewayRuleRequest(
            string ruleId,
            bool? enabled,
            string? description,
            global::Vercel.UpdateAiGatewayRuleRequestAction? action)
        {
            this.RuleId = ruleId ?? throw new global::System.ArgumentNullException(nameof(ruleId));
            this.Enabled = enabled;
            this.Description = description;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAiGatewayRuleRequest" /> class.
        /// </summary>
        public UpdateAiGatewayRuleRequest()
        {
        }

    }
}