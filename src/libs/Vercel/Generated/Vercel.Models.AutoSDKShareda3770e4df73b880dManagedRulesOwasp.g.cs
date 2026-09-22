
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda3770e4df73b880dManagedRulesOwasp
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda3770e4df73b880dManagedRulesOwaspActionJsonConverter))]
        public global::Vercel.AutoSDKShareda3770e4df73b880dManagedRulesOwaspAction? Action { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShareda3770e4df73b880dManagedRulesOwasp" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda3770e4df73b880dManagedRulesOwasp(
            bool active,
            global::Vercel.AutoSDKShareda3770e4df73b880dManagedRulesOwaspAction? action)
        {
            this.Action = action;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda3770e4df73b880dManagedRulesOwasp" /> class.
        /// </summary>
        public AutoSDKShareda3770e4df73b880dManagedRulesOwasp()
        {
        }

    }
}