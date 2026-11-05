
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedf0cc1038a078908fManagedRulesBotFilter
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf0cc1038a078908fManagedRulesBotFilterActionJsonConverter))]
        public global::Vercel.AutoSDKSharedf0cc1038a078908fManagedRulesBotFilterAction? Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf0cc1038a078908fManagedRulesBotFilter" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf0cc1038a078908fManagedRulesBotFilter(
            bool active,
            global::Vercel.AutoSDKSharedf0cc1038a078908fManagedRulesBotFilterAction? action)
        {
            this.Action = action;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf0cc1038a078908fManagedRulesBotFilter" /> class.
        /// </summary>
        public AutoSDKSharedf0cc1038a078908fManagedRulesBotFilter()
        {
        }

    }
}