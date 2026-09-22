
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared47a8daa582c3a982
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
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared2394a93f745adbf6> Environments { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared47a8daa582c3a982KindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared47a8daa582c3a982Kind Kind { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared47a8daa582c3a982StateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared47a8daa582c3a982State State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typeName")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared47a8daa582c3a982TypeNameJsonConverter))]
        public global::Vercel.AutoSDKShared47a8daa582c3a982TypeName TypeName { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared47a8daa582c3a982Variant> Variants { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared47a8daa582c3a982" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared47a8daa582c3a982(
            double createdAt,
            string createdBy,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared2394a93f745adbf6> environments,
            string id,
            global::Vercel.AutoSDKShared47a8daa582c3a982Kind kind,
            string ownerId,
            string projectId,
            double revision,
            double seed,
            string slug,
            global::Vercel.AutoSDKShared47a8daa582c3a982State state,
            double updatedAt,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared47a8daa582c3a982Variant> variants,
            string? description,
            global::System.Collections.Generic.IList<string>? maintainerIds,
            bool? permanent,
            global::System.Collections.Generic.IList<string>? tags,
            global::Vercel.AutoSDKShared47a8daa582c3a982TypeName typeName,
            string? updatedBy)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared47a8daa582c3a982" /> class.
        /// </summary>
        public AutoSDKShared47a8daa582c3a982()
        {
        }

    }
}