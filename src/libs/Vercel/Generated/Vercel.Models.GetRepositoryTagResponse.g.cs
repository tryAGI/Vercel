
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetRepositoryTagResponse
    {
        /// <summary>
        /// A tag pointing at an image in a Vercel Container Registry repository, enriched with the backing image's metadata and VHS-readiness status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.VcrTag Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRepositoryTagResponse" /> class.
        /// </summary>
        /// <param name="tag">
        /// A tag pointing at an image in a Vercel Container Registry repository, enriched with the backing image's metadata and VHS-readiness status.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRepositoryTagResponse(
            global::Vercel.VcrTag tag)
        {
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRepositoryTagResponse" /> class.
        /// </summary>
        public GetRepositoryTagResponse()
        {
        }

    }
}