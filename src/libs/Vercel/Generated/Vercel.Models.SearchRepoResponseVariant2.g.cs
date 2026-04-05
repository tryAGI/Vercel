
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRepoResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitAccount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.SearchRepoResponseVariant2GitAccount GitAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.SearchRepoResponseVariant2Repo> Repos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRepoResponseVariant2" /> class.
        /// </summary>
        /// <param name="gitAccount"></param>
        /// <param name="repos"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRepoResponseVariant2(
            global::Vercel.SearchRepoResponseVariant2GitAccount gitAccount,
            global::System.Collections.Generic.IList<global::Vercel.SearchRepoResponseVariant2Repo> repos)
        {
            this.GitAccount = gitAccount ?? throw new global::System.ArgumentNullException(nameof(gitAccount));
            this.Repos = repos ?? throw new global::System.ArgumentNullException(nameof(repos));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRepoResponseVariant2" /> class.
        /// </summary>
        public SearchRepoResponseVariant2()
        {
        }
    }
}