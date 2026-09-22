
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateFlagSegmentResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateFlagSegmentResponseData Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hint { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typeName")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateFlagSegmentResponseTypeNameJsonConverter))]
        public global::Vercel.CreateFlagSegmentResponseTypeName TypeName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="data"></param>
        /// <param name="hint"></param>
        /// <param name="id"></param>
        /// <param name="label"></param>
        /// <param name="projectId"></param>
        /// <param name="slug"></param>
        /// <param name="updatedAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="description"></param>
        /// <param name="typeName"></param>
        /// <param name="usedByFlags"></param>
        /// <param name="usedBySegments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagSegmentResponse(
            double createdAt,
            global::Vercel.CreateFlagSegmentResponseData data,
            string hint,
            string id,
            string label,
            string projectId,
            string slug,
            double updatedAt,
            string? createdBy,
            string? description,
            global::Vercel.CreateFlagSegmentResponseTypeName typeName,
            global::System.Collections.Generic.IList<string>? usedByFlags,
            global::System.Collections.Generic.IList<string>? usedBySegments)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Description = description;
            this.Hint = hint ?? throw new global::System.ArgumentNullException(nameof(hint));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.TypeName = typeName;
            this.UpdatedAt = updatedAt;
            this.UsedByFlags = usedByFlags;
            this.UsedBySegments = usedBySegments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentResponse" /> class.
        /// </summary>
        public CreateFlagSegmentResponse()
        {
        }

    }
}