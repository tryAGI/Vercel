
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Flag
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagEnvironments2> Environments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FlagKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.FlagKind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintainerIds")]
        public global::System.Collections.Generic.IList<string>? MaintainerIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permanent")]
        public bool? Permanent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Revision { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Seed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FlagStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.FlagState State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typeName")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FlagTypeNameJsonConverter))]
        public global::Vercel.FlagTypeName TypeName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variants")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.FlagVariant> Variants { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Vercel.FlagMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Flag" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="environments"></param>
        /// <param name="id"></param>
        /// <param name="kind"></param>
        /// <param name="ownerId"></param>
        /// <param name="projectId"></param>
        /// <param name="revision"></param>
        /// <param name="seed"></param>
        /// <param name="slug"></param>
        /// <param name="state"></param>
        /// <param name="updatedAt"></param>
        /// <param name="variants"></param>
        /// <param name="description"></param>
        /// <param name="maintainerIds"></param>
        /// <param name="permanent"></param>
        /// <param name="tags"></param>
        /// <param name="typeName"></param>
        /// <param name="updatedBy"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flag(
            double createdAt,
            string createdBy,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagEnvironments2> environments,
            string id,
            global::Vercel.FlagKind kind,
            string ownerId,
            string projectId,
            double revision,
            double seed,
            string slug,
            global::Vercel.FlagState state,
            double updatedAt,
            global::System.Collections.Generic.IList<global::Vercel.FlagVariant> variants,
            string? description,
            global::System.Collections.Generic.IList<string>? maintainerIds,
            bool? permanent,
            global::System.Collections.Generic.IList<string>? tags,
            global::Vercel.FlagTypeName typeName,
            string? updatedBy,
            global::Vercel.FlagMetadata? metadata)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.Description = description;
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Kind = kind;
            this.MaintainerIds = maintainerIds;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Permanent = permanent;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Revision = revision;
            this.Seed = seed;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.State = state;
            this.Tags = tags;
            this.TypeName = typeName;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Variants = variants ?? throw new global::System.ArgumentNullException(nameof(variants));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flag" /> class.
        /// </summary>
        public Flag()
        {
        }

    }
}