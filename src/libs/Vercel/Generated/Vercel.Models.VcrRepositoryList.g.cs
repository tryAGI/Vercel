
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A paginated list of Vercel Container Registry repositories.
    /// </summary>
    public sealed partial class VcrRepositoryList
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.VcrRepository> Repositories { get; set; }

        /// <summary>
        /// Cursor to fetch the next page of results, when more are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrRepositoryList" /> class.
        /// </summary>
        /// <param name="repositories"></param>
        /// <param name="nextCursor">
        /// Cursor to fetch the next page of results, when more are available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VcrRepositoryList(
            global::System.Collections.Generic.IList<global::Vercel.VcrRepository> repositories,
            string? nextCursor)
        {
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrRepositoryList" /> class.
        /// </summary>
        public VcrRepositoryList()
        {
        }

    }
}