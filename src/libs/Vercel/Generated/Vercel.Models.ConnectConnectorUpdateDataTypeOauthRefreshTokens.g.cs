
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Refresh token settings.
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeOauthRefreshTokens
    {
        /// <summary>
        /// Whether this OAuth grant is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeOauthRefreshTokens" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether this OAuth grant is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeOauthRefreshTokens(
            bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeOauthRefreshTokens" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeOauthRefreshTokens()
        {
        }

    }
}