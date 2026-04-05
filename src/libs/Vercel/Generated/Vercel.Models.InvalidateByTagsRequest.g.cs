
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InvalidateByTagsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.InvalidateByTagsRequestTargetJsonConverter))]
        public global::Vercel.InvalidateByTagsRequestTarget? Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidateByTagsRequest" /> class.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="target"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvalidateByTagsRequest(
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, string> tags,
            global::Vercel.InvalidateByTagsRequestTarget? target)
        {
            this.Tags = tags;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidateByTagsRequest" /> class.
        /// </summary>
        public InvalidateByTagsRequest()
        {
        }
    }
}