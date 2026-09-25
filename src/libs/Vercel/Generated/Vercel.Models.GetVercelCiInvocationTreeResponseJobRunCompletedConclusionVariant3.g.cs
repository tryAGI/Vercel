
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVercelCiInvocationTreeResponseJobRunCompletedConclusionVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiInvocationTreeResponseJobRunCompletedConclusionVariant3" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVercelCiInvocationTreeResponseJobRunCompletedConclusionVariant3(
            string result,
            string reason)
        {
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiInvocationTreeResponseJobRunCompletedConclusionVariant3" /> class.
        /// </summary>
        public GetVercelCiInvocationTreeResponseJobRunCompletedConclusionVariant3()
        {
        }

    }
}