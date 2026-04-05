
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFlagSegmentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// The entity who created the segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The data of the segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateFlagSegmentRequestData Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentRequest" /> class.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="label"></param>
        /// <param name="data">
        /// The data of the segment
        /// </param>
        /// <param name="hint"></param>
        /// <param name="createdBy">
        /// The entity who created the segment
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagSegmentRequest(
            string slug,
            string label,
            global::Vercel.CreateFlagSegmentRequestData data,
            string hint,
            string? createdBy,
            string? description)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.CreatedBy = createdBy;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Hint = hint ?? throw new global::System.ArgumentNullException(nameof(hint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentRequest" /> class.
        /// </summary>
        public CreateFlagSegmentRequest()
        {
        }
    }
}