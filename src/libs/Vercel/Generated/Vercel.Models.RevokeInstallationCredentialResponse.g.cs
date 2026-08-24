
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RevokeInstallationCredentialResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Revoked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("already_revoked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AlreadyRevoked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeInstallationCredentialResponse" /> class.
        /// </summary>
        /// <param name="revoked"></param>
        /// <param name="alreadyRevoked"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RevokeInstallationCredentialResponse(
            bool revoked,
            bool alreadyRevoked)
        {
            this.Revoked = revoked;
            this.AlreadyRevoked = alreadyRevoked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeInstallationCredentialResponse" /> class.
        /// </summary>
        public RevokeInstallationCredentialResponse()
        {
        }

    }
}