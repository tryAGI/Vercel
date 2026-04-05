
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Instructions for creating a user scoped protection bypass
    /// </summary>
    public sealed partial class PatchUrlProtectionBypassRequestVariant2Scope
    {
        /// <summary>
        /// Specified user id for the scoped bypass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Specified email for the scoped bypass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Invitation status for the user scoped bypass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchUrlProtectionBypassRequestVariant2ScopeAccessJsonConverter))]
        public global::Vercel.PatchUrlProtectionBypassRequestVariant2ScopeAccess? Access { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUrlProtectionBypassRequestVariant2Scope" /> class.
        /// </summary>
        /// <param name="userId">
        /// Specified user id for the scoped bypass.
        /// </param>
        /// <param name="email">
        /// Specified email for the scoped bypass.
        /// </param>
        /// <param name="access">
        /// Invitation status for the user scoped bypass.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchUrlProtectionBypassRequestVariant2Scope(
            string? userId,
            string? email,
            global::Vercel.PatchUrlProtectionBypassRequestVariant2ScopeAccess? access)
        {
            this.UserId = userId;
            this.Email = email;
            this.Access = access;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUrlProtectionBypassRequestVariant2Scope" /> class.
        /// </summary>
        public PatchUrlProtectionBypassRequestVariant2Scope()
        {
        }
    }
}