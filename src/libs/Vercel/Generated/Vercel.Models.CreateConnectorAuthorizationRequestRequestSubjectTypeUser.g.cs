
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorAuthorizationRequestRequestSubjectTypeUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateConnectorAuthorizationRequestRequestSubjectTypeUserTypeJsonConverter))]
        public global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUserType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        public string? Issuer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorAuthorizationRequestRequestSubjectTypeUser" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="issuer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorAuthorizationRequestRequestSubjectTypeUser(
            global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUserType type,
            string? id,
            string? issuer)
        {
            this.Type = type;
            this.Id = id;
            this.Issuer = issuer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorAuthorizationRequestRequestSubjectTypeUser" /> class.
        /// </summary>
        public CreateConnectorAuthorizationRequestRequestSubjectTypeUser()
        {
        }

    }
}