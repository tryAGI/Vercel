
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedca611ecff4bbfd16ExpectationRef
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationAttempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InvocationAttempt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvocationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobDefinitionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobDefinitionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobRunAttempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double JobRunAttempt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedca611ecff4bbfd16ExpectationRef" /> class.
        /// </summary>
        /// <param name="invocationAttempt"></param>
        /// <param name="invocationId"></param>
        /// <param name="jobDefinitionId"></param>
        /// <param name="jobRunAttempt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedca611ecff4bbfd16ExpectationRef(
            double invocationAttempt,
            string invocationId,
            string jobDefinitionId,
            double jobRunAttempt)
        {
            this.InvocationAttempt = invocationAttempt;
            this.InvocationId = invocationId ?? throw new global::System.ArgumentNullException(nameof(invocationId));
            this.JobDefinitionId = jobDefinitionId ?? throw new global::System.ArgumentNullException(nameof(jobDefinitionId));
            this.JobRunAttempt = jobRunAttempt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedca611ecff4bbfd16ExpectationRef" /> class.
        /// </summary>
        public AutoSDKSharedca611ecff4bbfd16ExpectationRef()
        {
        }

    }
}