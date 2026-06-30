
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Converted VHS drive data, present once an image has been optimized for sandbox launch.
    /// </summary>
    public sealed partial class VcrImageListItemVhs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// Optional VHS drive configuration captured for an optimized image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Vercel.VcrImageListItemVhsConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrImageListItemVhs" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="digest"></param>
        /// <param name="config">
        /// Optional VHS drive configuration captured for an optimized image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VcrImageListItemVhs(
            string path,
            string digest,
            global::Vercel.VcrImageListItemVhsConfig? config)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrImageListItemVhs" /> class.
        /// </summary>
        public VcrImageListItemVhs()
        {
        }

    }
}