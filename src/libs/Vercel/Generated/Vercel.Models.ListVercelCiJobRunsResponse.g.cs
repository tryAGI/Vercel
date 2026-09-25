
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVercelCiJobRunsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobRuns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ListVercelCiJobRunsResponseJobRun> JobRuns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiJobRunsResponse" /> class.
        /// </summary>
        /// <param name="jobRuns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVercelCiJobRunsResponse(
            global::System.Collections.Generic.IList<global::Vercel.ListVercelCiJobRunsResponseJobRun> jobRuns)
        {
            this.JobRuns = jobRuns ?? throw new global::System.ArgumentNullException(nameof(jobRuns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiJobRunsResponse" /> class.
        /// </summary>
        public ListVercelCiJobRunsResponse()
        {
        }

    }
}