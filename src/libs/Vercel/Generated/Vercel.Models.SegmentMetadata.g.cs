
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::Vercel.SegmentMetadataCreator? Creator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentMetadata" /> class.
        /// </summary>
        /// <param name="creator"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentMetadata(
            global::Vercel.SegmentMetadataCreator? creator)
        {
            this.Creator = creator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentMetadata" /> class.
        /// </summary>
        public SegmentMetadata()
        {
        }
    }
}