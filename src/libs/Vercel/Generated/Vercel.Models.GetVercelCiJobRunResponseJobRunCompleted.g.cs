
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVercelCiJobRunResponseJobRunCompleted
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.GetVercelCiJobRunResponseJobRunCompletedConclusionVariant1, global::Vercel.GetVercelCiJobRunResponseJobRunCompletedConclusionVariant2, global::Vercel.GetVercelCiJobRunResponseJobRunCompletedConclusionVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.GetVercelCiJobRunResponseJobRunCompletedConclusionVariant1, global::Vercel.GetVercelCiJobRunResponseJobRunCompletedConclusionVariant2, global::Vercel.GetVercelCiJobRunResponseJobRunCompletedConclusionVariant3> Conclusion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiJobRunResponseJobRunCompleted" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVercelCiJobRunResponseJobRunCompleted(
            double completedAt,
            global::Vercel.AnyOf<global::Vercel.GetVercelCiJobRunResponseJobRunCompletedConclusionVariant1, global::Vercel.GetVercelCiJobRunResponseJobRunCompletedConclusionVariant2, global::Vercel.GetVercelCiJobRunResponseJobRunCompletedConclusionVariant3> conclusion)
        {
            this.CompletedAt = completedAt;
            this.Conclusion = conclusion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiJobRunResponseJobRunCompleted" /> class.
        /// </summary>
        public GetVercelCiJobRunResponseJobRunCompleted()
        {
        }

    }
}