
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMicrofrontendsInGroupResponseProjectAbuse
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
        public required global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectAbuseHistoryItem> History { get; set; }

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
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectAbuseBlock? Block { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockHistory")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant2, global::Vercel.GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant3, global::Vercel.GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant4>>? BlockHistory { get; set; }

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
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectAbuse" /> class.
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
        public GetMicrofrontendsInGroupResponseProjectAbuse(
            global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectAbuseHistoryItem> history,
            double updatedAt,
            string? scanner,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectAbuseBlock? block,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant2, global::Vercel.GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant3, global::Vercel.GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant4>>? blockHistory,
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
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectAbuse" /> class.
        /// </summary>
        public GetMicrofrontendsInGroupResponseProjectAbuse()
        {
        }
    }
}