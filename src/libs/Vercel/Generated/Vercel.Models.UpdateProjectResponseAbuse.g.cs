
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectResponseAbuse
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
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateProjectResponseAbuseHistoryItem> History { get; set; }

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
        public global::Vercel.UpdateProjectResponseAbuseBlock? Block { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockHistory")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.UpdateProjectResponseAbuseBlockHistoryItemVariant1, global::Vercel.UpdateProjectResponseAbuseBlockHistoryItemVariant2, global::Vercel.UpdateProjectResponseAbuseBlockHistoryItemVariant3, global::Vercel.UpdateProjectResponseAbuseBlockHistoryItemVariant4>>? BlockHistory { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateProjectResponseAbuse" /> class.
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
        public UpdateProjectResponseAbuse(
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectResponseAbuseHistoryItem> history,
            double updatedAt,
            string? scanner,
            global::Vercel.UpdateProjectResponseAbuseBlock? block,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.UpdateProjectResponseAbuseBlockHistoryItemVariant1, global::Vercel.UpdateProjectResponseAbuseBlockHistoryItemVariant2, global::Vercel.UpdateProjectResponseAbuseBlockHistoryItemVariant3, global::Vercel.UpdateProjectResponseAbuseBlockHistoryItemVariant4>>? blockHistory,
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
        /// Initializes a new instance of the <see cref="UpdateProjectResponseAbuse" /> class.
        /// </summary>
        public UpdateProjectResponseAbuse()
        {
        }
    }
}