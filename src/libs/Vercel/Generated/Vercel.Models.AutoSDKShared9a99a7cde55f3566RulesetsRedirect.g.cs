
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9a99a7cde55f3566RulesetsRedirect
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Location { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permanent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Permanent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9a99a7cde55f3566RulesetsRedirect" /> class.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="permanent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9a99a7cde55f3566RulesetsRedirect(
            string location,
            bool permanent)
        {
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
            this.Permanent = permanent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9a99a7cde55f3566RulesetsRedirect" /> class.
        /// </summary>
        public AutoSDKShared9a99a7cde55f3566RulesetsRedirect()
        {
        }

    }
}