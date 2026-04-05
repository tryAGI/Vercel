
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectEnvResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decrypted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Decrypted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectEnvResponseVariant1TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectEnvResponseVariant1Type Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.GetProjectEnvResponseVariant1TargetItem>, global::Vercel.GetProjectEnvResponseVariant1Target?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetProjectEnvResponseVariant1TargetItem>, global::Vercel.GetProjectEnvResponseVariant1Target?>? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranch")]
        public string? GitBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationId")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentHint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant1, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant2, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant3, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant4, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant5, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant6, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant7, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant8, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant9, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant10, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant11, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant12, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant13, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant14, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant15>))]
        public global::Vercel.OneOf<global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant1, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant2, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant3, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant4, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant5, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant6, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant7, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant8, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant9, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant10, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant11, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant12, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant13, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant14, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant15>? ContentHint { get; set; }

        /// <summary>
        /// Similar to `contentHints`, but should not be exposed to the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalContentHint")]
        public global::Vercel.GetProjectEnvResponseVariant1InternalContentHint? InternalContentHint { get; set; }

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
        /// Initializes a new instance of the <see cref="GetProjectEnvResponseVariant1" /> class.
        /// </summary>
        /// <param name="decrypted"></param>
        /// <param name="type"></param>
        /// <param name="key"></param>
        /// <param name="edgeConfigId"></param>
        /// <param name="edgeConfigTokenId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="id"></param>
        /// <param name="createdBy"></param>
        /// <param name="target"></param>
        /// <param name="gitBranch"></param>
        /// <param name="updatedBy"></param>
        /// <param name="sunsetSecretId">
        /// This is used to identify variables that have been migrated from type secret to sensitive.
        /// </param>
        /// <param name="legacyValue">
        /// Legacy now-encryption ciphertext, present after migration swaps value/vsmValue
        /// </param>
        /// <param name="configurationId"></param>
        /// <param name="contentHint"></param>
        /// <param name="internalContentHint">
        /// Similar to `contentHints`, but should not be exposed to the user.
        /// </param>
        /// <param name="comment"></param>
        /// <param name="customEnvironmentIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectEnvResponseVariant1(
            bool decrypted,
            global::Vercel.GetProjectEnvResponseVariant1Type type,
            string key,
            string? edgeConfigId,
            string? edgeConfigTokenId,
            double? createdAt,
            double? updatedAt,
            string? id,
            string? createdBy,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetProjectEnvResponseVariant1TargetItem>, global::Vercel.GetProjectEnvResponseVariant1Target?>? target,
            string? gitBranch,
            string? updatedBy,
            string? sunsetSecretId,
            string? legacyValue,
            string? configurationId,
            global::Vercel.OneOf<global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant1, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant2, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant3, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant4, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant5, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant6, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant7, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant8, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant9, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant10, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant11, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant12, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant13, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant14, global::Vercel.GetProjectEnvResponseVariant1ContentHintVariant15>? contentHint,
            global::Vercel.GetProjectEnvResponseVariant1InternalContentHint? internalContentHint,
            string? comment,
            global::System.Collections.Generic.IList<string>? customEnvironmentIds)
        {
            this.Decrypted = decrypted;
            this.Type = type;
            this.EdgeConfigId = edgeConfigId;
            this.EdgeConfigTokenId = edgeConfigTokenId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Id = id;
            this.CreatedBy = createdBy;
            this.Target = target;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.GitBranch = gitBranch;
            this.UpdatedBy = updatedBy;
            this.SunsetSecretId = sunsetSecretId;
            this.LegacyValue = legacyValue;
            this.ConfigurationId = configurationId;
            this.ContentHint = contentHint;
            this.InternalContentHint = internalContentHint;
            this.Comment = comment;
            this.CustomEnvironmentIds = customEnvironmentIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectEnvResponseVariant1" /> class.
        /// </summary>
        public GetProjectEnvResponseVariant1()
        {
        }
    }
}