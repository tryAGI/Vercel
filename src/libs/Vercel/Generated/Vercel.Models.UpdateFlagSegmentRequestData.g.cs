
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The data of the segment
    /// </summary>
    public sealed partial class UpdateFlagSegmentRequestData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentRequestDataRule>? Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentRequestDataIncludeItem>>>? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentRequestDataExcludeItem>>>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentRequestData" /> class.
        /// </summary>
        /// <param name="rules"></param>
        /// <param name="include"></param>
        /// <param name="exclude"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSegmentRequestData(
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentRequestDataRule>? rules,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentRequestDataIncludeItem>>>? include,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentRequestDataExcludeItem>>>? exclude)
        {
            this.Rules = rules;
            this.Include = include;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentRequestData" /> class.
        /// </summary>
        public UpdateFlagSegmentRequestData()
        {
        }
    }
}