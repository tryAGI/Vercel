
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportConnectorTokensResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Accepted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Imported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ImportConnectorTokensResponseToken> Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportConnectorTokensResponse" /> class.
        /// </summary>
        /// <param name="accepted"></param>
        /// <param name="imported"></param>
        /// <param name="tokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportConnectorTokensResponse(
            double accepted,
            double imported,
            global::System.Collections.Generic.IList<global::Vercel.ImportConnectorTokensResponseToken> tokens)
        {
            this.Accepted = accepted;
            this.Imported = imported;
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportConnectorTokensResponse" /> class.
        /// </summary>
        public ImportConnectorTokensResponse()
        {
        }

    }
}