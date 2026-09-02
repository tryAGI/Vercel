
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeOauthServerConfigJwksKey
    {
        /// <summary>
        /// JSON Web Key type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kty")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kty { get; set; }

        /// <summary>
        /// JSON Web Key identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kid")]
        public string? Kid { get; set; }

        /// <summary>
        /// Intended key use: signing or encryption.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorUpdateDataTypeOauthServerConfigJwksKeyUseJsonConverter))]
        public global::Vercel.ConnectConnectorUpdateDataTypeOauthServerConfigJwksKeyUse? Use { get; set; }

        /// <summary>
        /// Operations permitted for this key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_ops")]
        public global::System.Collections.Generic.IList<string>? KeyOps { get; set; }

        /// <summary>
        /// Algorithm intended for this key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alg")]
        public string? Alg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeOauthServerConfigJwksKey" /> class.
        /// </summary>
        /// <param name="kty">
        /// JSON Web Key type.
        /// </param>
        /// <param name="kid">
        /// JSON Web Key identifier.
        /// </param>
        /// <param name="use">
        /// Intended key use: signing or encryption.
        /// </param>
        /// <param name="keyOps">
        /// Operations permitted for this key.
        /// </param>
        /// <param name="alg">
        /// Algorithm intended for this key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeOauthServerConfigJwksKey(
            string kty,
            string? kid,
            global::Vercel.ConnectConnectorUpdateDataTypeOauthServerConfigJwksKeyUse? use,
            global::System.Collections.Generic.IList<string>? keyOps,
            string? alg)
        {
            this.Kty = kty ?? throw new global::System.ArgumentNullException(nameof(kty));
            this.Kid = kid;
            this.Use = use;
            this.KeyOps = keyOps;
            this.Alg = alg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeOauthServerConfigJwksKey" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeOauthServerConfigJwksKey()
        {
        }

    }
}