
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Shared metadata for a Flags SDK key, safe to return on both LIST and CREATE. Never contains cleartext secrets.
    /// </summary>
    public sealed partial class GetSdkKeysResponseDataItem
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetSdkKeysResponseDataItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetSdkKeysResponseDataItemType Type { get; set; }

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
        /// Partially-masked representation of the SDK key value, safe to display in UIs. The value is the `vf_&lt;type&gt;_` prefix followed by the first 3 characters of the secret portion and a fixed 8-character `*` mask (e.g. `vf_server_abc********`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partialKeyValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PartialKeyValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSdkKeysResponseDataItem" /> class.
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="projectId"></param>
        /// <param name="type"></param>
        /// <param name="environment"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="partialKeyValue">
        /// Partially-masked representation of the SDK key value, safe to display in UIs. The value is the `vf_&lt;type&gt;_` prefix followed by the first 3 characters of the secret portion and a fixed 8-character `*` mask (e.g. `vf_server_abc********`).
        /// </param>
        /// <param name="label"></param>
        /// <param name="deletedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSdkKeysResponseDataItem(
            string hashKey,
            string projectId,
            global::Vercel.GetSdkKeysResponseDataItemType type,
            string environment,
            string createdBy,
            double createdAt,
            double updatedAt,
            string partialKeyValue,
            string? label,
            double? deletedAt)
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
            this.PartialKeyValue = partialKeyValue ?? throw new global::System.ArgumentNullException(nameof(partialKeyValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSdkKeysResponseDataItem" /> class.
        /// </summary>
        public GetSdkKeysResponseDataItem()
        {
        }

    }
}