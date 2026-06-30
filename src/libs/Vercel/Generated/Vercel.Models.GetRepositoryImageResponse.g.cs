
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRepositoryImageResponse
    {
        /// <summary>
        /// A single image with its tags, status and resolved Dockerfile layer history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.VcrImageDetail Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRepositoryImageResponse" /> class.
        /// </summary>
        /// <param name="image">
        /// A single image with its tags, status and resolved Dockerfile layer history.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRepositoryImageResponse(
            global::Vercel.VcrImageDetail image)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRepositoryImageResponse" /> class.
        /// </summary>
        public GetRepositoryImageResponse()
        {
        }

    }
}