
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthUserFeatureBlocksWebAnalytics
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
        [global::System.Text.Json.Serialization.JsonPropertyName("isCurrentlyBlocked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCurrentlyBlocked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserFeatureBlocksWebAnalytics" /> class.
        /// </summary>
        /// <param name="isCurrentlyBlocked"></param>
        /// <param name="blockedFrom"></param>
        /// <param name="blockedUntil"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserFeatureBlocksWebAnalytics(
            bool isCurrentlyBlocked,
            double? blockedFrom,
            double? blockedUntil)
        {
            this.BlockedFrom = blockedFrom;
            this.BlockedUntil = blockedUntil;
            this.IsCurrentlyBlocked = isCurrentlyBlocked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserFeatureBlocksWebAnalytics" /> class.
        /// </summary>
        public AuthUserFeatureBlocksWebAnalytics()
        {
        }
    }
}