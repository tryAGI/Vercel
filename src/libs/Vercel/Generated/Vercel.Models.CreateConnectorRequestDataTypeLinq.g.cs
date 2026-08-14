
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeLinq
    {
        /// <summary>
        /// Linq partner API token for the shared line.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumbers")]
        public global::System.Collections.Generic.IList<string>? PhoneNumbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeLinq" /> class.
        /// </summary>
        /// <param name="apiToken">
        /// Linq partner API token for the shared line.
        /// </param>
        /// <param name="phoneNumbers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeLinq(
            string apiToken,
            global::System.Collections.Generic.IList<string>? phoneNumbers)
        {
            this.ApiToken = apiToken ?? throw new global::System.ArgumentNullException(nameof(apiToken));
            this.PhoneNumbers = phoneNumbers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeLinq" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeLinq()
        {
        }

    }
}