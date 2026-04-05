
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectAbuse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scanner")]
        public string? Scanner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectAbuseHistoryItem> History { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block")]
        public global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlock? Block { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockHistory")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant1, global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant2, global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant3, global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4>>? BlockHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interstitial")]
        public bool? Interstitial { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectAbuse" /> class.
        /// </summary>
        /// <param name="history"></param>
        /// <param name="updatedAt"></param>
        /// <param name="scanner"></param>
        /// <param name="block"></param>
        /// <param name="blockHistory"></param>
        /// <param name="interstitial"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectAbuse(
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectAbuseHistoryItem> history,
            double updatedAt,
            string? scanner,
            global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlock? block,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant1, global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant2, global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant3, global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4>>? blockHistory,
            bool? interstitial)
        {
            this.Scanner = scanner;
            this.History = history ?? throw new global::System.ArgumentNullException(nameof(history));
            this.UpdatedAt = updatedAt;
            this.Block = block;
            this.BlockHistory = blockHistory;
            this.Interstitial = interstitial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectAbuse" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectAbuse()
        {
        }
    }
}