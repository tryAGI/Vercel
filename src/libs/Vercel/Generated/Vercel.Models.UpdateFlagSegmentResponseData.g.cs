
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagSegmentResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentResponseDataRule>? Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentResponseDataIncludeItem>>>? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentResponseDataExcludeItem>>>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentResponseData" /> class.
        /// </summary>
        /// <param name="rules"></param>
        /// <param name="include"></param>
        /// <param name="exclude"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSegmentResponseData(
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentResponseDataRule>? rules,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentResponseDataIncludeItem>>>? include,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentResponseDataExcludeItem>>>? exclude)
        {
            this.Rules = rules;
            this.Include = include;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentResponseData" /> class.
        /// </summary>
        public UpdateFlagSegmentResponseData()
        {
        }
    }
}