
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant112
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rulesetName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RulesetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleGroups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.UserEventPayloadVariant112RuleGroups2> RuleGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant112" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="rulesetName"></param>
        /// <param name="ruleGroups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant112(
            string projectId,
            string rulesetName,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UserEventPayloadVariant112RuleGroups2> ruleGroups)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.RulesetName = rulesetName ?? throw new global::System.ArgumentNullException(nameof(rulesetName));
            this.RuleGroups = ruleGroups ?? throw new global::System.ArgumentNullException(nameof(ruleGroups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant112" /> class.
        /// </summary>
        public UserEventPayloadVariant112()
        {
        }
    }
}