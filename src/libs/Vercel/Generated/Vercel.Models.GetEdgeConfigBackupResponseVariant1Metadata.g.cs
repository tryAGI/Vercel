
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEdgeConfigBackupResponseVariant1Metadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsCount")]
        public double? ItemsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsBytes")]
        public double? ItemsBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigBackupResponseVariant1Metadata" /> class.
        /// </summary>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="itemsCount"></param>
        /// <param name="itemsBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEdgeConfigBackupResponseVariant1Metadata(
            string? updatedAt,
            string? updatedBy,
            double? itemsCount,
            double? itemsBytes)
        {
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.ItemsCount = itemsCount;
            this.ItemsBytes = itemsBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigBackupResponseVariant1Metadata" /> class.
        /// </summary>
        public GetEdgeConfigBackupResponseVariant1Metadata()
        {
        }
    }
}