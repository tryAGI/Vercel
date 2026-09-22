
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared5387a0e7cacff827
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block")]
        public global::Vercel.AutoSDKShared5387a0e7cacff827Block? Block { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockHistory")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedacb9976f956c2a3b>? BlockHistory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared5387a0e7cacff827HistoryItem> History { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interstitial")]
        public bool? Interstitial { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interstitialHistory")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared5387a0e7cacff827InterstitialHistoryItem>? InterstitialHistory { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared5387a0e7cacff827" /> class.
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
        public AutoSDKShared5387a0e7cacff827(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared5387a0e7cacff827HistoryItem> history,
            double updatedAt,
            global::Vercel.AutoSDKShared5387a0e7cacff827Block? block,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedacb9976f956c2a3b>? blockHistory,
            bool? interstitial,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared5387a0e7cacff827InterstitialHistoryItem>? interstitialHistory,
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
        /// Initializes a new instance of the <see cref="AutoSDKShared5387a0e7cacff827" /> class.
        /// </summary>
        public AutoSDKShared5387a0e7cacff827()
        {
        }

    }
}