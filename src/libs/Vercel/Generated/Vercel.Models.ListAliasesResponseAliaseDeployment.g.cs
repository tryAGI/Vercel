
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A map with the deployment ID, URL and metadata
    /// </summary>
    public sealed partial class ListAliasesResponseAliaseDeployment
    {
        /// <summary>
        /// The deployment unique identifier<br/>
        /// Example: dpl_5m8CQaRBm3FnWRW1od3wKTpaECPx
        /// </summary>
        /// <example>dpl_5m8CQaRBm3FnWRW1od3wKTpaECPx</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The deployment unique URL<br/>
        /// Example: my-instant-deployment-3ij3cxz9qr.now.sh
        /// </summary>
        /// <example>my-instant-deployment-3ij3cxz9qr.now.sh</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The deployment metadata<br/>
        /// Example: {}
        /// </summary>
        /// <example>{}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public string? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAliasesResponseAliaseDeployment" /> class.
        /// </summary>
        /// <param name="id">
        /// The deployment unique identifier<br/>
        /// Example: dpl_5m8CQaRBm3FnWRW1od3wKTpaECPx
        /// </param>
        /// <param name="url">
        /// The deployment unique URL<br/>
        /// Example: my-instant-deployment-3ij3cxz9qr.now.sh
        /// </param>
        /// <param name="meta">
        /// The deployment metadata<br/>
        /// Example: {}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAliasesResponseAliaseDeployment(
            string id,
            string url,
            string? meta)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAliasesResponseAliaseDeployment" /> class.
        /// </summary>
        public ListAliasesResponseAliaseDeployment()
        {
        }
    }
}