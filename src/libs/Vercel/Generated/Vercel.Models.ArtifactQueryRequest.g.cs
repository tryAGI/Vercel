
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArtifactQueryRequest
    {
        /// <summary>
        /// artifact hashes<br/>
        /// Example: [12HKQaOmR5t5Uy6vdcQsNIiZgHGB, 34HKQaOmR5t5Uy6vasdasdasdasd]
        /// </summary>
        /// <example>[12HKQaOmR5t5Uy6vdcQsNIiZgHGB, 34HKQaOmR5t5Uy6vasdasdasdasd]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Hashes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactQueryRequest" /> class.
        /// </summary>
        /// <param name="hashes">
        /// artifact hashes<br/>
        /// Example: [12HKQaOmR5t5Uy6vdcQsNIiZgHGB, 34HKQaOmR5t5Uy6vasdasdasdasd]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtifactQueryRequest(
            global::System.Collections.Generic.IList<string> hashes)
        {
            this.Hashes = hashes ?? throw new global::System.ArgumentNullException(nameof(hashes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactQueryRequest" /> class.
        /// </summary>
        public ArtifactQueryRequest()
        {
        }
    }
}