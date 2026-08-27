
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Client-facing view of the `speedInsightsFree` ingestion block. The dashboard needs `blockReason` to tell usage pauses apart from admin blocks.
    /// </summary>
    public sealed partial class AuthUserFeatureBlocksSpeedInsightsFree
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedFrom")]
        public double? BlockedFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedUntil")]
        public double? BlockedUntil { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthUserFeatureBlocksSpeedInsightsFreeBlockReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AuthUserFeatureBlocksSpeedInsightsFreeBlockReason BlockReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCurrentlyBlocked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCurrentlyBlocked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserFeatureBlocksSpeedInsightsFree" /> class.
        /// </summary>
        /// <param name="blockReason"></param>
        /// <param name="isCurrentlyBlocked"></param>
        /// <param name="blockedFrom"></param>
        /// <param name="blockedUntil"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserFeatureBlocksSpeedInsightsFree(
            global::Vercel.AuthUserFeatureBlocksSpeedInsightsFreeBlockReason blockReason,
            bool isCurrentlyBlocked,
            double? blockedFrom,
            double? blockedUntil)
        {
            this.BlockedFrom = blockedFrom;
            this.BlockedUntil = blockedUntil;
            this.BlockReason = blockReason;
            this.IsCurrentlyBlocked = isCurrentlyBlocked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserFeatureBlocksSpeedInsightsFree" /> class.
        /// </summary>
        public AuthUserFeatureBlocksSpeedInsightsFree()
        {
        }

    }
}