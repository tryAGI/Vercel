
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiGatewayRuleListItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::Vercel.AiGatewayRuleListItemAction? Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match")]
        public global::Vercel.AiGatewayRuleListItemMatch? Match { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RuleId { get; set; }

        /// <summary>
        /// Rule that takes precedence over this enabled rule for the same model, so this one never applies
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadowedBy")]
        public string? ShadowedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AiGatewayRuleListItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AiGatewayRuleListItemType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayRuleListItem" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="enabled"></param>
        /// <param name="ownerId"></param>
        /// <param name="ruleId"></param>
        /// <param name="type"></param>
        /// <param name="updatedAt"></param>
        /// <param name="action"></param>
        /// <param name="createdBy"></param>
        /// <param name="deleted"></param>
        /// <param name="description"></param>
        /// <param name="match"></param>
        /// <param name="shadowedBy">
        /// Rule that takes precedence over this enabled rule for the same model, so this one never applies
        /// </param>
        /// <param name="updatedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayRuleListItem(
            double createdAt,
            bool enabled,
            string ownerId,
            string ruleId,
            global::Vercel.AiGatewayRuleListItemType type,
            double updatedAt,
            global::Vercel.AiGatewayRuleListItemAction? action,
            string? createdBy,
            bool? deleted,
            string? description,
            global::Vercel.AiGatewayRuleListItemMatch? match,
            string? shadowedBy,
            string? updatedBy)
        {
            this.Action = action;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Deleted = deleted;
            this.Description = description;
            this.Enabled = enabled;
            this.Match = match;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.RuleId = ruleId ?? throw new global::System.ArgumentNullException(nameof(ruleId));
            this.ShadowedBy = shadowedBy;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayRuleListItem" /> class.
        /// </summary>
        public AiGatewayRuleListItem()
        {
        }

    }
}