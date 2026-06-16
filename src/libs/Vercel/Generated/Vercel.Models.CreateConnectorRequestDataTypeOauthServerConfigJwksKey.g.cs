
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeOauthServerConfigJwksKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kty")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kid")]
        public string? Kid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateConnectorRequestDataTypeOauthServerConfigJwksKeyUseJsonConverter))]
        public global::Vercel.CreateConnectorRequestDataTypeOauthServerConfigJwksKeyUse? Use { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_ops")]
        public global::System.Collections.Generic.IList<string>? KeyOps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alg")]
        public string? Alg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeOauthServerConfigJwksKey" /> class.
        /// </summary>
        /// <param name="kty"></param>
        /// <param name="kid"></param>
        /// <param name="use"></param>
        /// <param name="keyOps"></param>
        /// <param name="alg"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeOauthServerConfigJwksKey(
            string kty,
            string? kid,
            global::Vercel.CreateConnectorRequestDataTypeOauthServerConfigJwksKeyUse? use,
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
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeOauthServerConfigJwksKey" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeOauthServerConfigJwksKey()
        {
        }

    }
}