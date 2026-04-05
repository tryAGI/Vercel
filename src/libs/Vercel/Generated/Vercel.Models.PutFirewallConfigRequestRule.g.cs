
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutFirewallConfigRequestRule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditionGroup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.PutFirewallConfigRequestRuleConditionGroupItem> ConditionGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigRequestRuleAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        public bool? Valid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validationErrors")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>))]
        public global::Vercel.AnyOf<global::System.Collections.Generic.IList<string>, string>? ValidationErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigRequestRule" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="active"></param>
        /// <param name="conditionGroup"></param>
        /// <param name="action"></param>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="valid"></param>
        /// <param name="validationErrors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigRequestRule(
            string name,
            bool active,
            global::System.Collections.Generic.IList<global::Vercel.PutFirewallConfigRequestRuleConditionGroupItem> conditionGroup,
            global::Vercel.PutFirewallConfigRequestRuleAction action,
            string? id,
            string? description,
            bool? valid,
            global::Vercel.AnyOf<global::System.Collections.Generic.IList<string>, string>? validationErrors)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Active = active;
            this.ConditionGroup = conditionGroup ?? throw new global::System.ArgumentNullException(nameof(conditionGroup));
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Valid = valid;
            this.ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigRequestRule" /> class.
        /// </summary>
        public PutFirewallConfigRequestRule()
        {
        }
    }
}