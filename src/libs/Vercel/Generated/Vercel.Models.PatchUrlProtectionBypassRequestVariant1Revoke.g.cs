
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional instructions for revoking and regenerating a shareable link
    /// </summary>
    public sealed partial class PatchUrlProtectionBypassRequestVariant1Revoke
    {
        /// <summary>
        /// Sharebale link to revoked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Secret { get; set; }

        /// <summary>
        /// Whether or not a new shareable link should be created after the provided secret is revoked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regenerate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Regenerate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUrlProtectionBypassRequestVariant1Revoke" /> class.
        /// </summary>
        /// <param name="secret">
        /// Sharebale link to revoked
        /// </param>
        /// <param name="regenerate">
        /// Whether or not a new shareable link should be created after the provided secret is revoked
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchUrlProtectionBypassRequestVariant1Revoke(
            string secret,
            bool regenerate)
        {
            this.Secret = secret ?? throw new global::System.ArgumentNullException(nameof(secret));
            this.Regenerate = regenerate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUrlProtectionBypassRequestVariant1Revoke" /> class.
        /// </summary>
        public PatchUrlProtectionBypassRequestVariant1Revoke()
        {
        }
    }
}