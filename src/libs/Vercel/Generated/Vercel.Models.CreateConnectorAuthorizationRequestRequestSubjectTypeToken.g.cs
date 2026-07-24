
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorAuthorizationRequestRequestSubjectTypeToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateConnectorAuthorizationRequestRequestSubjectTypeTokenTypeJsonConverter))]
        public global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeTokenType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorAuthorizationRequestRequestSubjectTypeToken" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorAuthorizationRequestRequestSubjectTypeToken(
            string token,
            global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeTokenType type)
        {
            this.Type = type;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorAuthorizationRequestRequestSubjectTypeToken" /> class.
        /// </summary>
        public CreateConnectorAuthorizationRequestRequestSubjectTypeToken()
        {
        }

    }
}