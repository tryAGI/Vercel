
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant122NewOwnerSiftScores2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasons")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant122NewOwnerSiftScoresReason> Reasons { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant122NewOwnerSiftScores2" /> class.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="reasons"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant122NewOwnerSiftScores2(
            double score,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant122NewOwnerSiftScoresReason> reasons)
        {
            this.Score = score;
            this.Reasons = reasons ?? throw new global::System.ArgumentNullException(nameof(reasons));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant122NewOwnerSiftScores2" /> class.
        /// </summary>
        public UserEventPayloadVariant122NewOwnerSiftScores2()
        {
        }
    }
}