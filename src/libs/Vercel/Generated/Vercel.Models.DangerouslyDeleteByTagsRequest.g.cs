
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DangerouslyDeleteByTagsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revalidationDeadlineSeconds")]
        public double? RevalidationDeadlineSeconds { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.DangerouslyDeleteByTagsRequestTargetJsonConverter))]
        public global::Vercel.DangerouslyDeleteByTagsRequestTarget? Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DangerouslyDeleteByTagsRequest" /> class.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="revalidationDeadlineSeconds"></param>
        /// <param name="target"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DangerouslyDeleteByTagsRequest(
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, string> tags,
            double? revalidationDeadlineSeconds,
            global::Vercel.DangerouslyDeleteByTagsRequestTarget? target)
        {
            this.RevalidationDeadlineSeconds = revalidationDeadlineSeconds;
            this.Tags = tags;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DangerouslyDeleteByTagsRequest" /> class.
        /// </summary>
        public DangerouslyDeleteByTagsRequest()
        {
        }
    }
}