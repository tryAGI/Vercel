
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportConnectorTokensResponseTokenSubjectVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ImportConnectorTokensResponseTokenSubjectVariant2TypeJsonConverter))]
        public global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        /// Initializes a new instance of the <see cref="ImportConnectorTokensResponseTokenSubjectVariant2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="issuer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportConnectorTokensResponseTokenSubjectVariant2(
            string id,
            global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant2Type type,
            string? issuer)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Issuer = issuer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportConnectorTokensResponseTokenSubjectVariant2" /> class.
        /// </summary>
        public ImportConnectorTokensResponseTokenSubjectVariant2()
        {
        }

    }
}