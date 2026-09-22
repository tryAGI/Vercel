
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Since September 2026. Set on the live `abuse.block` only, by the consumer that auto-registers this project's production git SHA in the lineage blocklist, so unblocking can disable the row this block created. Absent means this block registered nothing, which includes the case where registration was skipped because the SHA already belonged to an earlier block. Unblock must therefore clear only what is named here, never the project's current SHA, or it would disable another block's row.
    /// </summary>
    public sealed partial class AutoSDKSharedacb9976f956c2a3bVariant1RegisteredShaBlock
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedacb9976f956c2a3bVariant1RegisteredShaBlock" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="sha"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedacb9976f956c2a3bVariant1RegisteredShaBlock(
            string createdAt,
            string createdBy,
            string sha)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedacb9976f956c2a3bVariant1RegisteredShaBlock" /> class.
        /// </summary>
        public AutoSDKSharedacb9976f956c2a3bVariant1RegisteredShaBlock()
        {
        }

    }
}