
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InvalidateBySrcImagesRequest
    {
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
        /// Initializes a new instance of the <see cref="InvalidateBySrcImagesRequest" /> class.
        /// </summary>
        /// <param name="srcImages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvalidateBySrcImagesRequest(
            global::System.Collections.Generic.IList<string> srcImages)
        {
            this.SrcImages = srcImages ?? throw new global::System.ArgumentNullException(nameof(srcImages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidateBySrcImagesRequest" /> class.
        /// </summary>
        public InvalidateBySrcImagesRequest()
        {
        }
    }
}