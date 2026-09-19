
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateFlagSettingsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSettingsResponseEntitie> Entities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Environments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagSettingsResponseMetadata Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        public string? OwnerId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagSettingsResponseTypeNameJsonConverter))]
        public global::Vercel.UpdateFlagSettingsResponseTypeName TypeName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSettingsResponse" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="entities"></param>
        /// <param name="environments"></param>
        /// <param name="metadata"></param>
        /// <param name="projectId"></param>
        /// <param name="createdAt"></param>
        /// <param name="ownerId"></param>
        /// <param name="typeName"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSettingsResponse(
            bool enabled,
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSettingsResponseEntitie> entities,
            global::System.Collections.Generic.IList<string> environments,
            global::Vercel.UpdateFlagSettingsResponseMetadata metadata,
            string projectId,
            double? createdAt,
            string? ownerId,
            global::Vercel.UpdateFlagSettingsResponseTypeName typeName,
            double? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.Enabled = enabled;
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.OwnerId = ownerId;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.TypeName = typeName;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSettingsResponse" /> class.
        /// </summary>
        public UpdateFlagSettingsResponse()
        {
        }

    }
}