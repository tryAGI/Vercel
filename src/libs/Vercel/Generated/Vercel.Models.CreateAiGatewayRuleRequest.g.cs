
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAiGatewayRuleRequest
    {
        /// <summary>
        /// `rewrite` sends requests for the matched model to another model. `deny` rejects them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateAiGatewayRuleRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateAiGatewayRuleRequestType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateAiGatewayRuleRequestMatch Match { get; set; }

        /// <summary>
        /// Required when `type` is `rewrite`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::Vercel.CreateAiGatewayRuleRequestAction? Action { get; set; }

        /// <summary>
        /// Whether the rule is enabled. Defaults to `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// A free-text note about the rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiGatewayRuleRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// `rewrite` sends requests for the matched model to another model. `deny` rejects them.
        /// </param>
        /// <param name="match"></param>
        /// <param name="action">
        /// Required when `type` is `rewrite`.
        /// </param>
        /// <param name="enabled">
        /// Whether the rule is enabled. Defaults to `true`.
        /// </param>
        /// <param name="description">
        /// A free-text note about the rule.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAiGatewayRuleRequest(
            global::Vercel.CreateAiGatewayRuleRequestType type,
            global::Vercel.CreateAiGatewayRuleRequestMatch match,
            global::Vercel.CreateAiGatewayRuleRequestAction? action,
            bool? enabled,
            string? description)
        {
            this.Type = type;
            this.Match = match ?? throw new global::System.ArgumentNullException(nameof(match));
            this.Action = action;
            this.Enabled = enabled;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiGatewayRuleRequest" /> class.
        /// </summary>
        public CreateAiGatewayRuleRequest()
        {
        }

    }
}