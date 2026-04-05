
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagSegmentResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedByFlags")]
        public global::System.Collections.Generic.IList<string>? UsedByFlags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedBySegments")]
        public global::System.Collections.Generic.IList<string>? UsedBySegments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typeName")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagSegmentResponseTypeNameJsonConverter))]
        public global::Vercel.UpdateFlagSegmentResponseTypeName TypeName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagSegmentResponseData Data { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentResponse2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="label"></param>
        /// <param name="slug"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="projectId"></param>
        /// <param name="data"></param>
        /// <param name="hint"></param>
        /// <param name="description"></param>
        /// <param name="createdBy"></param>
        /// <param name="usedByFlags"></param>
        /// <param name="usedBySegments"></param>
        /// <param name="typeName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSegmentResponse2(
            string id,
            string label,
            string slug,
            double createdAt,
            double updatedAt,
            string projectId,
            global::Vercel.UpdateFlagSegmentResponseData data,
            string hint,
            string? description,
            string? createdBy,
            global::System.Collections.Generic.IList<string>? usedByFlags,
            global::System.Collections.Generic.IList<string>? usedBySegments,
            global::Vercel.UpdateFlagSegmentResponseTypeName typeName)
        {
            this.Description = description;
            this.CreatedBy = createdBy;
            this.UsedByFlags = usedByFlags;
            this.UsedBySegments = usedBySegments;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.TypeName = typeName;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Hint = hint ?? throw new global::System.ArgumentNullException(nameof(hint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentResponse2" /> class.
        /// </summary>
        public UpdateFlagSegmentResponse2()
        {
        }
    }
}