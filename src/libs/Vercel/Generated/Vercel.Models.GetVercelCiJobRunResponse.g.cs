
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVercelCiJobRunResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobRun")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetVercelCiJobRunResponseJobRun JobRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiJobRunResponse" /> class.
        /// </summary>
        /// <param name="jobRun"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVercelCiJobRunResponse(
            global::Vercel.GetVercelCiJobRunResponseJobRun jobRun)
        {
            this.JobRun = jobRun ?? throw new global::System.ArgumentNullException(nameof(jobRun));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiJobRunResponse" /> class.
        /// </summary>
        public GetVercelCiJobRunResponse()
        {
        }

    }
}