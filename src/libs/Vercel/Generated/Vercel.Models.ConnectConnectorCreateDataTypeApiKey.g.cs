
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypeApiKey
    {
        /// <summary>
        /// Which subject the connector issues tokens for. Defaults to \"app\" (connector-level keys). \"user\" connectors store no connector-level values; each user supplies their own key during authorization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subjectType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorCreateDataTypeApiKeySubjectTypeJsonConverter))]
        public global::Vercel.ConnectConnectorCreateDataTypeApiKeySubjectType? SubjectType { get; set; }

        /// <summary>
        /// Initial API key values stored by the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorCreateDataTypeApiKeyValue>? Values { get; set; }

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
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeApiKey" /> class.
        /// </summary>
        /// <param name="subjectType">
        /// Which subject the connector issues tokens for. Defaults to \"app\" (connector-level keys). \"user\" connectors store no connector-level values; each user supplies their own key during authorization.
        /// </param>
        /// <param name="values">
        /// Initial API key values stored by the connector.
        /// </param>
        /// <param name="serviceUrls">
        /// The HTTPS resources the API key authenticates against.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypeApiKey(
            global::Vercel.ConnectConnectorCreateDataTypeApiKeySubjectType? subjectType,
            global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorCreateDataTypeApiKeyValue>? values,
            global::System.Collections.Generic.IList<string>? serviceUrls)
        {
            this.SubjectType = subjectType;
            this.Values = values;
            this.ServiceUrls = serviceUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeApiKey" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypeApiKey()
        {
        }

    }
}