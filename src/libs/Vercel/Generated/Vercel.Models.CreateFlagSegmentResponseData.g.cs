
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateFlagSegmentResponseData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.CreateFlagSegmentResponseDataExcludeItem>>>? Exclude { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.CreateFlagSegmentResponseDataIncludeItem>>>? Include { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateFlagSegmentResponseDataRule>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentResponseData" /> class.
        /// </summary>
        /// <param name="exclude"></param>
        /// <param name="include"></param>
        /// <param name="rules"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagSegmentResponseData(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.CreateFlagSegmentResponseDataExcludeItem>>>? exclude,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.CreateFlagSegmentResponseDataIncludeItem>>>? include,
            global::System.Collections.Generic.IList<global::Vercel.CreateFlagSegmentResponseDataRule>? rules)
        {
            this.Exclude = exclude;
            this.Include = include;
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentResponseData" /> class.
        /// </summary>
        public CreateFlagSegmentResponseData()
        {
        }

    }
}