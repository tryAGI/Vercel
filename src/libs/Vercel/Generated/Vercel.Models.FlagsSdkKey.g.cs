
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FlagsSdkKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HashKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FlagsSdkKeyTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.FlagsSdkKeyType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public double? DeletedAt { get; set; }

        /// <summary>
        /// Cleartext value of the SDK key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyValue")]
        public string? KeyValue { get; set; }

        /// <summary>
        /// Cleartext value of the Edge Config token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenValue")]
        public string? TokenValue { get; set; }

        /// <summary>
        /// Connection string for the SDK
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionString")]
        public string? ConnectionString { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlagsSdkKey" /> class.
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="projectId"></param>
        /// <param name="type"></param>
        /// <param name="environment"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="label"></param>
        /// <param name="deletedAt"></param>
        /// <param name="keyValue">
        /// Cleartext value of the SDK key
        /// </param>
        /// <param name="tokenValue">
        /// Cleartext value of the Edge Config token
        /// </param>
        /// <param name="connectionString">
        /// Connection string for the SDK
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlagsSdkKey(
            string hashKey,
            string projectId,
            global::Vercel.FlagsSdkKeyType type,
            string environment,
            string createdBy,
            double createdAt,
            double updatedAt,
            string? label,
            double? deletedAt,
            string? keyValue,
            string? tokenValue,
            string? connectionString)
        {
            this.HashKey = hashKey ?? throw new global::System.ArgumentNullException(nameof(hashKey));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Type = type;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Label = label;
            this.DeletedAt = deletedAt;
            this.KeyValue = keyValue;
            this.TokenValue = tokenValue;
            this.ConnectionString = connectionString;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlagsSdkKey" /> class.
        /// </summary>
        public FlagsSdkKey()
        {
        }
    }
}