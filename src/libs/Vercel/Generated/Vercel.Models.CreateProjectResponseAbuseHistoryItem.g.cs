
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectResponseAbuseHistoryItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scanner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scanner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string By { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ById { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double At { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseAbuseHistoryItem" /> class.
        /// </summary>
        /// <param name="scanner"></param>
        /// <param name="reason"></param>
        /// <param name="by"></param>
        /// <param name="byId"></param>
        /// <param name="at"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectResponseAbuseHistoryItem(
            string scanner,
            string reason,
            string by,
            string byId,
            double at)
        {
            this.Scanner = scanner ?? throw new global::System.ArgumentNullException(nameof(scanner));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.By = by ?? throw new global::System.ArgumentNullException(nameof(by));
            this.ById = byId ?? throw new global::System.ArgumentNullException(nameof(byId));
            this.At = at;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseAbuseHistoryItem" /> class.
        /// </summary>
        public CreateProjectResponseAbuseHistoryItem()
        {
        }
    }
}