
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFirewallConfigResponseRuleVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Vercel.GetFirewallConfigResponseRuleVariant1ConditionGroupItem> ConditionGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseRuleVariant1Action Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Valid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validationErrors")]
        public object? ValidationErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFirewallConfigResponseRuleVariant1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="active"></param>
        /// <param name="conditionGroup"></param>
        /// <param name="action"></param>
        /// <param name="valid"></param>
        /// <param name="description"></param>
        /// <param name="validationErrors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFirewallConfigResponseRuleVariant1(
            string id,
            string name,
            bool active,
            global::System.Collections.Generic.IList<global::Vercel.GetFirewallConfigResponseRuleVariant1ConditionGroupItem> conditionGroup,
            global::Vercel.GetFirewallConfigResponseRuleVariant1Action action,
            bool valid,
            string? description,
            object? validationErrors)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Active = active;
            this.ConditionGroup = conditionGroup ?? throw new global::System.ArgumentNullException(nameof(conditionGroup));
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Valid = valid;
            this.ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFirewallConfigResponseRuleVariant1" /> class.
        /// </summary>
        public GetFirewallConfigResponseRuleVariant1()
        {
        }
    }
}