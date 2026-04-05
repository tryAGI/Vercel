
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant2ProjectEnvItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant2ProjectEnvItemTargetItem>, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemTarget?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant2ProjectEnvItemTargetItem>, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemTarget?>? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant2ProjectEnvItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant2ProjectEnvItemType Type { get; set; }

        /// <summary>
        /// This is used to identify variables that have been migrated from type secret to sensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sunsetSecretId")]
        public string? SunsetSecretId { get; set; }

        /// <summary>
        /// Legacy now-encryption ciphertext, present after migration swaps value/vsmValue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legacyValue")]
        public string? LegacyValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decrypted")]
        public bool? Decrypted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vsmValue")]
        public string? VsmValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationId")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranch")]
        public string? GitBranch { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("contentHint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant1, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant2, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant3, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant4, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant5, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant6, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant7, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant8, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant9, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant10, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant11, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant12, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant13, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant14, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant15>))]
        public global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant1, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant2, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant3, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant4, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant5, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant6, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant7, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant8, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant9, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant10, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant11, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant12, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant13, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant14, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant15>? ContentHint { get; set; }

        /// <summary>
        /// Similar to `contentHints`, but should not be exposed to the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalContentHint")]
        public global::Vercel.GetProjectsResponseVariant2ProjectEnvItemInternalContentHint? InternalContentHint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironmentIds")]
        public global::System.Collections.Generic.IList<string>? CustomEnvironmentIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectEnvItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <param name="key"></param>
        /// <param name="target"></param>
        /// <param name="sunsetSecretId">
        /// This is used to identify variables that have been migrated from type secret to sensitive.
        /// </param>
        /// <param name="legacyValue">
        /// Legacy now-encryption ciphertext, present after migration swaps value/vsmValue
        /// </param>
        /// <param name="decrypted"></param>
        /// <param name="vsmValue"></param>
        /// <param name="id"></param>
        /// <param name="configurationId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="updatedBy"></param>
        /// <param name="gitBranch"></param>
        /// <param name="edgeConfigId"></param>
        /// <param name="edgeConfigTokenId"></param>
        /// <param name="contentHint"></param>
        /// <param name="internalContentHint">
        /// Similar to `contentHints`, but should not be exposed to the user.
        /// </param>
        /// <param name="comment"></param>
        /// <param name="customEnvironmentIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant2ProjectEnvItem(
            global::Vercel.GetProjectsResponseVariant2ProjectEnvItemType type,
            string value,
            string key,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant2ProjectEnvItemTargetItem>, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemTarget?>? target,
            string? sunsetSecretId,
            string? legacyValue,
            bool? decrypted,
            string? vsmValue,
            string? id,
            string? configurationId,
            double? createdAt,
            double? updatedAt,
            string? createdBy,
            string? updatedBy,
            string? gitBranch,
            string? edgeConfigId,
            string? edgeConfigTokenId,
            global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant1, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant2, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant3, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant4, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant5, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant6, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant7, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant8, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant9, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant10, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant11, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant12, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant13, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant14, global::Vercel.GetProjectsResponseVariant2ProjectEnvItemContentHintVariant15>? contentHint,
            global::Vercel.GetProjectsResponseVariant2ProjectEnvItemInternalContentHint? internalContentHint,
            string? comment,
            global::System.Collections.Generic.IList<string>? customEnvironmentIds)
        {
            this.Target = target;
            this.Type = type;
            this.SunsetSecretId = sunsetSecretId;
            this.LegacyValue = legacyValue;
            this.Decrypted = decrypted;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.VsmValue = vsmValue;
            this.Id = id;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.ConfigurationId = configurationId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
            this.GitBranch = gitBranch;
            this.EdgeConfigId = edgeConfigId;
            this.EdgeConfigTokenId = edgeConfigTokenId;
            this.ContentHint = contentHint;
            this.InternalContentHint = internalContentHint;
            this.Comment = comment;
            this.CustomEnvironmentIds = customEnvironmentIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectEnvItem" /> class.
        /// </summary>
        public GetProjectsResponseVariant2ProjectEnvItem()
        {
        }
    }
}