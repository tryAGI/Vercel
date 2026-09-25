
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVercelCiInvocationTreeResponseJobTaskRunCompleted
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.GetVercelCiInvocationTreeResponseJobTaskRunCompletedConclusionVariant1, global::Vercel.GetVercelCiInvocationTreeResponseJobTaskRunCompletedConclusionVariant2, global::Vercel.GetVercelCiInvocationTreeResponseJobTaskRunCompletedConclusionVariant3, global::Vercel.GetVercelCiInvocationTreeResponseJobTaskRunCompletedConclusionVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.GetVercelCiInvocationTreeResponseJobTaskRunCompletedConclusionVariant1, global::Vercel.GetVercelCiInvocationTreeResponseJobTaskRunCompletedConclusionVariant2, global::Vercel.GetVercelCiInvocationTreeResponseJobTaskRunCompletedConclusionVariant3, global::Vercel.GetVercelCiInvocationTreeResponseJobTaskRunCompletedConclusionVariant4> Conclusion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiInvocationTreeResponseJobTaskRunCompleted" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVercelCiInvocationTreeResponseJobTaskRunCompleted(
            double completedAt,
            global::Vercel.AnyOf<global::Vercel.GetVercelCiInvocationTreeResponseJobTaskRunCompletedConclusionVariant1, global::Vercel.GetVercelCiInvocationTreeResponseJobTaskRunCompletedConclusionVariant2, global::Vercel.GetVercelCiInvocationTreeResponseJobTaskRunCompletedConclusionVariant3, global::Vercel.GetVercelCiInvocationTreeResponseJobTaskRunCompletedConclusionVariant4> conclusion)
        {
            this.CompletedAt = completedAt;
            this.Conclusion = conclusion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiInvocationTreeResponseJobTaskRunCompleted" /> class.
        /// </summary>
        public GetVercelCiInvocationTreeResponseJobTaskRunCompleted()
        {
        }

    }
}