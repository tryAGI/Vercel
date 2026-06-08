
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeOauthServerConfigJwks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateConnectorRequestDataTypeOauthServerConfigJwksKey> Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeOauthServerConfigJwks" /> class.
        /// </summary>
        /// <param name="keys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeOauthServerConfigJwks(
            global::System.Collections.Generic.IList<global::Vercel.CreateConnectorRequestDataTypeOauthServerConfigJwksKey> keys)
        {
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeOauthServerConfigJwks" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeOauthServerConfigJwks()
        {
        }

    }
}