
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedfe1f84289679c6c4Blobs
    {
        /// <summary>
        /// Marks the team-level, Vercel-managed default blob project (`vercel-blob-default-project`) that orphan blob stores are scoped to when connected without an explicit project. Set only by internal storage flows and immutable after creation — guards rely on it to protect the connected stores from being lost when the project is deleted or transferred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefaultApp")]
        public bool? IsDefaultApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedfe1f84289679c6c4Blobs" /> class.
        /// </summary>
        /// <param name="isDefaultApp">
        /// Marks the team-level, Vercel-managed default blob project (`vercel-blob-default-project`) that orphan blob stores are scoped to when connected without an explicit project. Set only by internal storage flows and immutable after creation — guards rely on it to protect the connected stores from being lost when the project is deleted or transferred.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedfe1f84289679c6c4Blobs(
            bool? isDefaultApp)
        {
            this.IsDefaultApp = isDefaultApp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedfe1f84289679c6c4Blobs" /> class.
        /// </summary>
        public AutoSDKSharedfe1f84289679c6c4Blobs()
        {
        }

    }
}