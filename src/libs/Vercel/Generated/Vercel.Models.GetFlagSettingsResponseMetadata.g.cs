
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetFlagSettingsResponseMetadata
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeFlagCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ActiveFlagCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archivedFlagCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ArchivedFlagCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configUpdatedAt")]
        public double? ConfigUpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packRevision")]
        public double? PackRevision { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packSizeInBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PackSizeInBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SegmentCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFlagSettingsResponseMetadata" /> class.
        /// </summary>
        /// <param name="activeFlagCount"></param>
        /// <param name="archivedFlagCount"></param>
        /// <param name="packSizeInBytes"></param>
        /// <param name="segmentCount"></param>
        /// <param name="configUpdatedAt"></param>
        /// <param name="packRevision"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFlagSettingsResponseMetadata(
            double activeFlagCount,
            double archivedFlagCount,
            double packSizeInBytes,
            double segmentCount,
            double? configUpdatedAt,
            double? packRevision)
        {
            this.ActiveFlagCount = activeFlagCount;
            this.ArchivedFlagCount = archivedFlagCount;
            this.ConfigUpdatedAt = configUpdatedAt;
            this.PackRevision = packRevision;
            this.PackSizeInBytes = packSizeInBytes;
            this.SegmentCount = segmentCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFlagSettingsResponseMetadata" /> class.
        /// </summary>
        public GetFlagSettingsResponseMetadata()
        {
        }

    }
}