
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateProjectResponseEnvItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationId")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// Provider-specific content hint metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentHint")]
        public object? ContentHint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironmentIds")]
        public global::System.Collections.Generic.IList<string>? CustomEnvironmentIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decrypted")]
        public bool? Decrypted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigId")]
        public string? EdgeConfigId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigTokenId")]
        public string? EdgeConfigTokenId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranch")]
        public string? GitBranch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Similar to `contentHints`, but should not be exposed to the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalContentHint")]
        public global::Vercel.UpdateProjectResponseEnvItemInternalContentHint? InternalContentHint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Legacy now-encryption ciphertext, present after migration swaps value/vsmValue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legacyValue")]
        public string? LegacyValue { get; set; }

        /// <summary>
        /// This is used to identify variables that have been migrated from type secret to sensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sunsetSecretId")]
        public string? SunsetSecretId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.UpdateProjectResponseEnvItemTarget?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.UpdateProjectResponseEnvItemTarget?>? Target { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectResponseEnvItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateProjectResponseEnvItemType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// User-facing config/secret model. When set, authoritative for new code paths. Legacy rows omit this field and callers fall back to existing `type` behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectResponseEnvItemVisibilityJsonConverter))]
        public global::Vercel.UpdateProjectResponseEnvItemVisibility? Visibility { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vsmValue")]
        public string? VsmValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseEnvItem" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="configurationId"></param>
        /// <param name="contentHint">
        /// Provider-specific content hint metadata.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="customEnvironmentIds"></param>
        /// <param name="decrypted"></param>
        /// <param name="edgeConfigId"></param>
        /// <param name="edgeConfigTokenId"></param>
        /// <param name="gitBranch"></param>
        /// <param name="id"></param>
        /// <param name="internalContentHint">
        /// Similar to `contentHints`, but should not be exposed to the user.
        /// </param>
        /// <param name="legacyValue">
        /// Legacy now-encryption ciphertext, present after migration swaps value/vsmValue
        /// </param>
        /// <param name="sunsetSecretId">
        /// This is used to identify variables that have been migrated from type secret to sensitive.
        /// </param>
        /// <param name="target"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="visibility">
        /// User-facing config/secret model. When set, authoritative for new code paths. Legacy rows omit this field and callers fall back to existing `type` behavior.
        /// </param>
        /// <param name="vsmValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponseEnvItem(
            string key,
            global::Vercel.UpdateProjectResponseEnvItemType type,
            string value,
            string? comment,
            string? configurationId,
            object? contentHint,
            double? createdAt,
            string? createdBy,
            global::System.Collections.Generic.IList<string>? customEnvironmentIds,
            bool? decrypted,
            string? edgeConfigId,
            string? edgeConfigTokenId,
            string? gitBranch,
            string? id,
            global::Vercel.UpdateProjectResponseEnvItemInternalContentHint? internalContentHint,
            string? legacyValue,
            string? sunsetSecretId,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.UpdateProjectResponseEnvItemTarget?>? target,
            double? updatedAt,
            string? updatedBy,
            global::Vercel.UpdateProjectResponseEnvItemVisibility? visibility,
            string? vsmValue)
        {
            this.Comment = comment;
            this.ConfigurationId = configurationId;
            this.ContentHint = contentHint;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.CustomEnvironmentIds = customEnvironmentIds;
            this.Decrypted = decrypted;
            this.EdgeConfigId = edgeConfigId;
            this.EdgeConfigTokenId = edgeConfigTokenId;
            this.GitBranch = gitBranch;
            this.Id = id;
            this.InternalContentHint = internalContentHint;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.LegacyValue = legacyValue;
            this.SunsetSecretId = sunsetSecretId;
            this.Target = target;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Visibility = visibility;
            this.VsmValue = vsmValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseEnvItem" /> class.
        /// </summary>
        public UpdateProjectResponseEnvItem()
        {
        }

    }
}