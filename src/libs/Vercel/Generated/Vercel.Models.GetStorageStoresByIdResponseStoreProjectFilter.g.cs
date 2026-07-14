
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetStorageStoresByIdResponseStoreProjectFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git")]
        public global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGit? Git { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStorageStoresByIdResponseStoreProjectFilter" /> class.
        /// </summary>
        /// <param name="git"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetStorageStoresByIdResponseStoreProjectFilter(
            global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGit? git)
        {
            this.Git = git;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStorageStoresByIdResponseStoreProjectFilter" /> class.
        /// </summary>
        public GetStorageStoresByIdResponseStoreProjectFilter()
        {
        }

    }
}