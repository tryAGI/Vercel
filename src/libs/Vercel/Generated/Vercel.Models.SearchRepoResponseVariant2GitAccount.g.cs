
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRepoResponseVariant2GitAccount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.SearchRepoResponseVariant2GitAccountProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.SearchRepoResponseVariant2GitAccountProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaceId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Vercel.OneOf<string, double?>? NamespaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRepoResponseVariant2GitAccount" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="namespaceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRepoResponseVariant2GitAccount(
            global::Vercel.SearchRepoResponseVariant2GitAccountProvider provider,
            global::Vercel.OneOf<string, double?>? namespaceId)
        {
            this.Provider = provider;
            this.NamespaceId = namespaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRepoResponseVariant2GitAccount" /> class.
        /// </summary>
        public SearchRepoResponseVariant2GitAccount()
        {
        }
    }
}