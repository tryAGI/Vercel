
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadArtifactResponse
    {
        /// <summary>
        /// Array of URLs where the artifact was updated<br/>
        /// Example: [https://api.vercel.com/v2/now/artifact/12HKQaOmR5t5Uy6vdcQsNIiZgHGB]
        /// </summary>
        /// <example>[https://api.vercel.com/v2/now/artifact/12HKQaOmR5t5Uy6vdcQsNIiZgHGB]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Urls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadArtifactResponse" /> class.
        /// </summary>
        /// <param name="urls">
        /// Array of URLs where the artifact was updated<br/>
        /// Example: [https://api.vercel.com/v2/now/artifact/12HKQaOmR5t5Uy6vdcQsNIiZgHGB]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadArtifactResponse(
            global::System.Collections.Generic.IList<string> urls)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadArtifactResponse" /> class.
        /// </summary>
        public UploadArtifactResponse()
        {
        }
    }
}