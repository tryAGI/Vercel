
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectResponseSecurityManagedRulesBotFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectResponseSecurityManagedRulesBotFilterActionJsonConverter))]
        public global::Vercel.UpdateProjectResponseSecurityManagedRulesBotFilterAction? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseSecurityManagedRulesBotFilter" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponseSecurityManagedRulesBotFilter(
            bool active,
            global::Vercel.UpdateProjectResponseSecurityManagedRulesBotFilterAction? action)
        {
            this.Active = active;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseSecurityManagedRulesBotFilter" /> class.
        /// </summary>
        public UpdateProjectResponseSecurityManagedRulesBotFilter()
        {
        }
    }
}