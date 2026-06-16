
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSources
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSourcesActionJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSourcesAction? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSources" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSources(
            bool active,
            global::Vercel.GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSourcesAction? action)
        {
            this.Active = active;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSources" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSources()
        {
        }

    }
}