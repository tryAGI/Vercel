
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared7e5cde0fd7c87b94ManagedRulesBotProtection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared7e5cde0fd7c87b94ManagedRulesBotProtectionActionJsonConverter))]
        public global::Vercel.AutoSDKShared7e5cde0fd7c87b94ManagedRulesBotProtectionAction? Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared7e5cde0fd7c87b94ManagedRulesBotProtection" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="action"></param>
        /// <param name="updatedAt"></param>
        /// <param name="userId"></param>
        /// <param name="username"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared7e5cde0fd7c87b94ManagedRulesBotProtection(
            bool active,
            global::Vercel.AutoSDKShared7e5cde0fd7c87b94ManagedRulesBotProtectionAction? action,
            string? updatedAt,
            string? userId,
            string? username)
        {
            this.Action = action;
            this.Active = active;
            this.UpdatedAt = updatedAt;
            this.UserId = userId;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared7e5cde0fd7c87b94ManagedRulesBotProtection" /> class.
        /// </summary>
        public AutoSDKShared7e5cde0fd7c87b94ManagedRulesBotProtection()
        {
        }

    }
}