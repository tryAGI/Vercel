
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMicrofrontendsInGroupResponseProjectEnvItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemTargetItem>, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemTarget?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemTargetItem>, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemTarget?>? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetMicrofrontendsInGroupResponseProjectEnvItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant2, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant3, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant4, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant5, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant6, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant7, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant8, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant9, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant10, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant11, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant12, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant13, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant14, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant15>))]
        public global::Vercel.OneOf<global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant2, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant3, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant4, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant5, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant6, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant7, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant8, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant9, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant10, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant11, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant12, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant13, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant14, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant15>? ContentHint { get; set; }

        /// <summary>
        /// Similar to `contentHints`, but should not be exposed to the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalContentHint")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemInternalContentHint? InternalContentHint { get; set; }

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
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectEnvItem" /> class.
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
        public GetMicrofrontendsInGroupResponseProjectEnvItem(
            global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemType type,
            string value,
            string key,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemTargetItem>, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemTarget?>? target,
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
            global::Vercel.OneOf<global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant2, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant3, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant4, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant5, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant6, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant7, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant8, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant9, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant10, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant11, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant12, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant13, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant14, global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant15>? contentHint,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItemInternalContentHint? internalContentHint,
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
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectEnvItem" /> class.
        /// </summary>
        public GetMicrofrontendsInGroupResponseProjectEnvItem()
        {
        }
    }
}