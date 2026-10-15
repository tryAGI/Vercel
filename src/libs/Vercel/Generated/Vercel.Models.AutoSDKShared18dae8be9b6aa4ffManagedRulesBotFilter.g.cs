
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared18dae8be9b6aa4ffManagedRulesBotFilter
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared18dae8be9b6aa4ffManagedRulesBotFilterActionJsonConverter))]
        public global::Vercel.AutoSDKShared18dae8be9b6aa4ffManagedRulesBotFilterAction? Action { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared18dae8be9b6aa4ffManagedRulesBotFilter" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared18dae8be9b6aa4ffManagedRulesBotFilter(
            bool active,
            global::Vercel.AutoSDKShared18dae8be9b6aa4ffManagedRulesBotFilterAction? action)
        {
            this.Action = action;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared18dae8be9b6aa4ffManagedRulesBotFilter" /> class.
        /// </summary>
        public AutoSDKShared18dae8be9b6aa4ffManagedRulesBotFilter()
        {
        }

    }
}