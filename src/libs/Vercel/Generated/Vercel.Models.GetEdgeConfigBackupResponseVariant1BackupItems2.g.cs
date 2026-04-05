
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEdgeConfigBackupResponseVariant1BackupItems2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.EdgeConfigItemValueJsonConverter))]
        public global::Vercel.EdgeConfigItemValue? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigBackupResponseVariant1BackupItems2" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEdgeConfigBackupResponseVariant1BackupItems2(
            double createdAt,
            double updatedAt,
            string? description,
            global::Vercel.EdgeConfigItemValue? value)
        {
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigBackupResponseVariant1BackupItems2" /> class.
        /// </summary>
        public GetEdgeConfigBackupResponseVariant1BackupItems2()
        {
        }
    }
}