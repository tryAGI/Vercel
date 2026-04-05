
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagSegmentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operations")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentRequestOperation>? Operations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The data of the segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Vercel.UpdateFlagSegmentRequestData? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hint")]
        public string? Hint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentRequest" /> class.
        /// </summary>
        /// <param name="operations"></param>
        /// <param name="label"></param>
        /// <param name="description"></param>
        /// <param name="data">
        /// The data of the segment
        /// </param>
        /// <param name="hint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSegmentRequest(
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSegmentRequestOperation>? operations,
            string? label,
            string? description,
            global::Vercel.UpdateFlagSegmentRequestData? data,
            string? hint)
        {
            this.Operations = operations;
            this.Label = label;
            this.Description = description;
            this.Data = data;
            this.Hint = hint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentRequest" /> class.
        /// </summary>
        public UpdateFlagSegmentRequest()
        {
        }
    }
}