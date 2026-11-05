
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedeb5fe0ead5db865cManagedRulesAiBots
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedeb5fe0ead5db865cManagedRulesAiBotsActionJsonConverter))]
        public global::Vercel.AutoSDKSharedeb5fe0ead5db865cManagedRulesAiBotsAction? Action { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharedeb5fe0ead5db865cManagedRulesAiBots" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="action"></param>
        /// <param name="updatedAt"></param>
        /// <param name="userId"></param>
        /// <param name="username"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedeb5fe0ead5db865cManagedRulesAiBots(
            bool active,
            global::Vercel.AutoSDKSharedeb5fe0ead5db865cManagedRulesAiBotsAction? action,
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
        /// Initializes a new instance of the <see cref="AutoSDKSharedeb5fe0ead5db865cManagedRulesAiBots" /> class.
        /// </summary>
        public AutoSDKSharedeb5fe0ead5db865cManagedRulesAiBots()
        {
        }

    }
}