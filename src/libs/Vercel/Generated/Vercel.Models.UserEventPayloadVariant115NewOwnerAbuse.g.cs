
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant115NewOwnerAbuse
    {
        /// <summary>
        /// Since June 2023
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockHistory")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerAbuseBlockHistoryItem>? BlockHistory { get; set; }

        /// <summary>
        /// Since March 2022. Helps abuse checks by tracking git auths. Format: `&lt;platform&gt;:&lt;detail&gt;:&lt;value&gt;`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitAuthHistory")]
        public global::System.Collections.Generic.IList<string>? GitAuthHistory { get; set; }

        /// <summary>
        /// (scanner history). Since November 2021. First element is newest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerAbuseHistoryItem>? History { get; set; }

        /// <summary>
        /// Since September 2023. How often did this owner trigger an actual git lineage deploy block?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitLineageBlocks")]
        public double? GitLineageBlocks { get; set; }

        /// <summary>
        /// Since September 2023. How often did this owner trigger a git lineage deploy block dry run?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitLineageBlocksDry")]
        public double? GitLineageBlocksDry { get; set; }

        /// <summary>
        /// Since November 2021. Guides the abuse scanner in build container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scanner")]
        public string? Scanner { get; set; }

        /// <summary>
        /// Since December 2025. UTC timestamp string of when an auto-unblock is scheduled. Format: "Wed, 03 Dec 2025 20:32:13 GMT"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduledUnblockAt")]
        public string? ScheduledUnblockAt { get; set; }

        /// <summary>
        /// Since November 2021
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationUserAgent")]
        public string? CreationUserAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationIp")]
        public string? CreationIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedPhoneNumbers")]
        public string? RemovedPhoneNumbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerAbuse" /> class.
        /// </summary>
        /// <param name="updatedAt">
        /// Since November 2021
        /// </param>
        /// <param name="blockHistory">
        /// Since June 2023
        /// </param>
        /// <param name="gitAuthHistory">
        /// Since March 2022. Helps abuse checks by tracking git auths. Format: `&lt;platform&gt;:&lt;detail&gt;:&lt;value&gt;`
        /// </param>
        /// <param name="history">
        /// (scanner history). Since November 2021. First element is newest.
        /// </param>
        /// <param name="gitLineageBlocks">
        /// Since September 2023. How often did this owner trigger an actual git lineage deploy block?
        /// </param>
        /// <param name="gitLineageBlocksDry">
        /// Since September 2023. How often did this owner trigger a git lineage deploy block dry run?
        /// </param>
        /// <param name="scanner">
        /// Since November 2021. Guides the abuse scanner in build container.
        /// </param>
        /// <param name="scheduledUnblockAt">
        /// Since December 2025. UTC timestamp string of when an auto-unblock is scheduled. Format: "Wed, 03 Dec 2025 20:32:13 GMT"
        /// </param>
        /// <param name="creationUserAgent"></param>
        /// <param name="creationIp"></param>
        /// <param name="removedPhoneNumbers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant115NewOwnerAbuse(
            double updatedAt,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerAbuseBlockHistoryItem>? blockHistory,
            global::System.Collections.Generic.IList<string>? gitAuthHistory,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerAbuseHistoryItem>? history,
            double? gitLineageBlocks,
            double? gitLineageBlocksDry,
            string? scanner,
            string? scheduledUnblockAt,
            string? creationUserAgent,
            string? creationIp,
            string? removedPhoneNumbers)
        {
            this.BlockHistory = blockHistory;
            this.GitAuthHistory = gitAuthHistory;
            this.History = history;
            this.GitLineageBlocks = gitLineageBlocks;
            this.GitLineageBlocksDry = gitLineageBlocksDry;
            this.Scanner = scanner;
            this.ScheduledUnblockAt = scheduledUnblockAt;
            this.UpdatedAt = updatedAt;
            this.CreationUserAgent = creationUserAgent;
            this.CreationIp = creationIp;
            this.RemovedPhoneNumbers = removedPhoneNumbers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerAbuse" /> class.
        /// </summary>
        public UserEventPayloadVariant115NewOwnerAbuse()
        {
        }
    }
}