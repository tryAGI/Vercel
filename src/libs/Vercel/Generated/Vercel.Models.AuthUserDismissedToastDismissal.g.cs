
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthUserDismissedToastDismissal
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScopeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserDismissedToastDismissal" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="scopeId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserDismissedToastDismissal(
            double createdAt,
            string scopeId)
        {
            this.CreatedAt = createdAt;
            this.ScopeId = scopeId ?? throw new global::System.ArgumentNullException(nameof(scopeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserDismissedToastDismissal" /> class.
        /// </summary>
        public AuthUserDismissedToastDismissal()
        {
        }

    }
}