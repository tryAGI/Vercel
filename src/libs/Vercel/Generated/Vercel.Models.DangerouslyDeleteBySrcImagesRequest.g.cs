
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DangerouslyDeleteBySrcImagesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revalidationDeadlineSeconds")]
        public double? RevalidationDeadlineSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("srcImages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SrcImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DangerouslyDeleteBySrcImagesRequest" /> class.
        /// </summary>
        /// <param name="srcImages"></param>
        /// <param name="revalidationDeadlineSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DangerouslyDeleteBySrcImagesRequest(
            global::System.Collections.Generic.IList<string> srcImages,
            double? revalidationDeadlineSeconds)
        {
            this.RevalidationDeadlineSeconds = revalidationDeadlineSeconds;
            this.SrcImages = srcImages ?? throw new global::System.ArgumentNullException(nameof(srcImages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DangerouslyDeleteBySrcImagesRequest" /> class.
        /// </summary>
        public DangerouslyDeleteBySrcImagesRequest()
        {
        }
    }
}