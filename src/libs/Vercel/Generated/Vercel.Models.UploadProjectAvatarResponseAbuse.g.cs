
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadProjectAvatarResponseAbuse
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
        public required global::System.Collections.Generic.IList<global::Vercel.UploadProjectAvatarResponseAbuseHistoryItem> History { get; set; }

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
        public global::Vercel.UploadProjectAvatarResponseAbuseBlock? Block { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockHistory")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.UploadProjectAvatarResponseAbuseBlockHistoryItemVariant1, global::Vercel.UploadProjectAvatarResponseAbuseBlockHistoryItemVariant2, global::Vercel.UploadProjectAvatarResponseAbuseBlockHistoryItemVariant3, global::Vercel.UploadProjectAvatarResponseAbuseBlockHistoryItemVariant4>>? BlockHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interstitial")]
        public bool? Interstitial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interstitialHistory")]
        public global::System.Collections.Generic.IList<global::Vercel.UploadProjectAvatarResponseAbuseInterstitialHistoryItem>? InterstitialHistory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseAbuse" /> class.
        /// </summary>
        /// <param name="history"></param>
        /// <param name="updatedAt"></param>
        /// <param name="scanner"></param>
        /// <param name="block"></param>
        /// <param name="blockHistory"></param>
        /// <param name="interstitial"></param>
        /// <param name="interstitialHistory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadProjectAvatarResponseAbuse(
            global::System.Collections.Generic.IList<global::Vercel.UploadProjectAvatarResponseAbuseHistoryItem> history,
            double updatedAt,
            string? scanner,
            global::Vercel.UploadProjectAvatarResponseAbuseBlock? block,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.UploadProjectAvatarResponseAbuseBlockHistoryItemVariant1, global::Vercel.UploadProjectAvatarResponseAbuseBlockHistoryItemVariant2, global::Vercel.UploadProjectAvatarResponseAbuseBlockHistoryItemVariant3, global::Vercel.UploadProjectAvatarResponseAbuseBlockHistoryItemVariant4>>? blockHistory,
            bool? interstitial,
            global::System.Collections.Generic.IList<global::Vercel.UploadProjectAvatarResponseAbuseInterstitialHistoryItem>? interstitialHistory)
        {
            this.Scanner = scanner;
            this.History = history ?? throw new global::System.ArgumentNullException(nameof(history));
            this.UpdatedAt = updatedAt;
            this.Block = block;
            this.BlockHistory = blockHistory;
            this.Interstitial = interstitial;
            this.InterstitialHistory = interstitialHistory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseAbuse" /> class.
        /// </summary>
        public UploadProjectAvatarResponseAbuse()
        {
        }

    }
}