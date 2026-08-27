
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Representation of a Flags SDK key returned by CREATE. Includes cleartext secrets (`keyValue`, `tokenValue`, `connectionString`) which are only ever disclosed once, on creation.
    /// </summary>
    public sealed partial class FlagsSdkKeyWithSecrets
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FlagsSdkKeyWithSecretsTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.FlagsSdkKeyWithSecretsType Type { get; set; }

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
        /// Cleartext value of the SDK key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyValue { get; set; }

        /// <summary>
        /// Cleartext value of the Global Config token, when the project has a Global Config connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenValue")]
        public string? TokenValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlagsSdkKeyWithSecrets" /> class.
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
        /// <param name="keyValue">
        /// Cleartext value of the SDK key.
        /// </param>
        /// <param name="label"></param>
        /// <param name="deletedAt"></param>
        /// <param name="tokenValue">
        /// Cleartext value of the Global Config token, when the project has a Global Config connection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlagsSdkKeyWithSecrets(
            string hashKey,
            string projectId,
            global::Vercel.FlagsSdkKeyWithSecretsType type,
            string environment,
            string createdBy,
            double createdAt,
            double updatedAt,
            string partialKeyValue,
            string keyValue,
            string? label,
            double? deletedAt,
            string? tokenValue)
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
            this.KeyValue = keyValue ?? throw new global::System.ArgumentNullException(nameof(keyValue));
            this.TokenValue = tokenValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlagsSdkKeyWithSecrets" /> class.
        /// </summary>
        public FlagsSdkKeyWithSecrets()
        {
        }

    }
}