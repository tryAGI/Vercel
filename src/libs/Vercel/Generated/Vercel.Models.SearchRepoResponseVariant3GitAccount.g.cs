
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchRepoResponseVariant3GitAccount
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaceId")]
        public string? NamespaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRepoResponseVariant3GitAccount" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="namespaceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRepoResponseVariant3GitAccount(
            string provider,
            string? namespaceId)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.NamespaceId = namespaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRepoResponseVariant3GitAccount" /> class.
        /// </summary>
        public SearchRepoResponseVariant3GitAccount()
        {
        }

    }
}