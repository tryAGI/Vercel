
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared429cd580a486c43eExpectationRef
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
        /// Initializes a new instance of the <see cref="AutoSDKShared429cd580a486c43eExpectationRef" /> class.
        /// </summary>
        /// <param name="invocationAttempt"></param>
        /// <param name="invocationId"></param>
        /// <param name="jobDefinitionId"></param>
        /// <param name="jobRunAttempt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared429cd580a486c43eExpectationRef(
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
        /// Initializes a new instance of the <see cref="AutoSDKShared429cd580a486c43eExpectationRef" /> class.
        /// </summary>
        public AutoSDKShared429cd580a486c43eExpectationRef()
        {
        }

    }
}