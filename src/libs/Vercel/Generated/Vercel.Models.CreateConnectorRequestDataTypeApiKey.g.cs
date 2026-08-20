
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeApiKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subjectType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateConnectorRequestDataTypeApiKeySubjectTypeJsonConverter))]
        public global::Vercel.CreateConnectorRequestDataTypeApiKeySubjectType? SubjectType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateConnectorRequestDataTypeApiKeyValue>? Values { get; set; }

        /// <summary>
        /// The HTTPS resources the API key authenticates against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceUrls")]
        public global::System.Collections.Generic.IList<string>? ServiceUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeApiKey" /> class.
        /// </summary>
        /// <param name="subjectType"></param>
        /// <param name="values"></param>
        /// <param name="serviceUrls">
        /// The HTTPS resources the API key authenticates against.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeApiKey(
            global::Vercel.CreateConnectorRequestDataTypeApiKeySubjectType? subjectType,
            global::System.Collections.Generic.IList<global::Vercel.CreateConnectorRequestDataTypeApiKeyValue>? values,
            global::System.Collections.Generic.IList<string>? serviceUrls)
        {
            this.SubjectType = subjectType;
            this.Values = values;
            this.ServiceUrls = serviceUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeApiKey" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeApiKey()
        {
        }

    }
}