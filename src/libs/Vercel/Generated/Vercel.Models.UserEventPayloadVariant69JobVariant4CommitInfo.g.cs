
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant69JobVariant4CommitInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("earliestSha")]
        public string? EarliestSha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant69JobVariant4CommitInfo" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="earliestSha"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant69JobVariant4CommitInfo(
            double total,
            string? earliestSha)
        {
            this.Total = total;
            this.EarliestSha = earliestSha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant69JobVariant4CommitInfo" /> class.
        /// </summary>
        public UserEventPayloadVariant69JobVariant4CommitInfo()
        {
        }
    }
}