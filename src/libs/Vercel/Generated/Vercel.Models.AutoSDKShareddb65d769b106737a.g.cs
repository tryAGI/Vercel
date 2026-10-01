
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareddb65d769b106737a
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block")]
        public global::Vercel.AutoSDKShareddb65d769b106737aBlock? Block { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockHistory")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedcd352219f9b13f14>? BlockHistory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareddb65d769b106737aHistoryItem> History { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interstitial")]
        public bool? Interstitial { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interstitialHistory")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareddb65d769b106737aInterstitialHistoryItem>? InterstitialHistory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scanner")]
        public string? Scanner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareddb65d769b106737a" /> class.
        /// </summary>
        /// <param name="history"></param>
        /// <param name="updatedAt"></param>
        /// <param name="block"></param>
        /// <param name="blockHistory"></param>
        /// <param name="interstitial"></param>
        /// <param name="interstitialHistory"></param>
        /// <param name="scanner"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareddb65d769b106737a(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareddb65d769b106737aHistoryItem> history,
            double updatedAt,
            global::Vercel.AutoSDKShareddb65d769b106737aBlock? block,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedcd352219f9b13f14>? blockHistory,
            bool? interstitial,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareddb65d769b106737aInterstitialHistoryItem>? interstitialHistory,
            string? scanner)
        {
            this.Block = block;
            this.BlockHistory = blockHistory;
            this.History = history ?? throw new global::System.ArgumentNullException(nameof(history));
            this.Interstitial = interstitial;
            this.InterstitialHistory = interstitialHistory;
            this.Scanner = scanner;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareddb65d769b106737a" /> class.
        /// </summary>
        public AutoSDKShareddb65d769b106737a()
        {
        }

    }
}