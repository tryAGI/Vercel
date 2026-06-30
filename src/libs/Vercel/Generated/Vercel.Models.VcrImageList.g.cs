
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A paginated list of images for a repository.
    /// </summary>
    public sealed partial class VcrImageList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.VcrImageListItem> Images { get; set; }

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
        /// Initializes a new instance of the <see cref="VcrImageList" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="nextCursor">
        /// Cursor to fetch the next page of results, when more are available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VcrImageList(
            global::System.Collections.Generic.IList<global::Vercel.VcrImageListItem> images,
            string? nextCursor)
        {
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrImageList" /> class.
        /// </summary>
        public VcrImageList()
        {
        }

    }
}