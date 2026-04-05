
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::Vercel.SegmentDataRule>? Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.SegmentDataIncludeItem>>>? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.SegmentDataExcludeItem>>>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentData" /> class.
        /// </summary>
        /// <param name="rules"></param>
        /// <param name="include"></param>
        /// <param name="exclude"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentData(
            global::System.Collections.Generic.IList<global::Vercel.SegmentDataRule>? rules,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.SegmentDataIncludeItem>>>? include,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.SegmentDataExcludeItem>>>? exclude)
        {
            this.Rules = rules;
            this.Include = include;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentData" /> class.
        /// </summary>
        public SegmentData()
        {
        }
    }
}