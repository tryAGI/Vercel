
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The data of the segment
    /// </summary>
    public sealed partial class CreateFlagSegmentRequestData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateFlagSegmentRequestDataRule>? Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.CreateFlagSegmentRequestDataIncludeItem>>>? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.CreateFlagSegmentRequestDataExcludeItem>>>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentRequestData" /> class.
        /// </summary>
        /// <param name="rules"></param>
        /// <param name="include"></param>
        /// <param name="exclude"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagSegmentRequestData(
            global::System.Collections.Generic.IList<global::Vercel.CreateFlagSegmentRequestDataRule>? rules,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.CreateFlagSegmentRequestDataIncludeItem>>>? include,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.CreateFlagSegmentRequestDataExcludeItem>>>? exclude)
        {
            this.Rules = rules;
            this.Include = include;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentRequestData" /> class.
        /// </summary>
        public CreateFlagSegmentRequestData()
        {
        }
    }
}