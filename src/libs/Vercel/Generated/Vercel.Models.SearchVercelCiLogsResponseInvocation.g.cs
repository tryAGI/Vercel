
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchVercelCiLogsResponseInvocation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvocationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Attempt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.SearchVercelCiLogsResponseInvocationTask> Tasks { get; set; }

        /// <summary>
        /// Matching lines from the setup logs. Present only when a setup line matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public global::Vercel.SearchVercelCiLogsResponseInvocationSetup? Setup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchVercelCiLogsResponseInvocation" /> class.
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="attempt"></param>
        /// <param name="tasks"></param>
        /// <param name="setup">
        /// Matching lines from the setup logs. Present only when a setup line matches.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchVercelCiLogsResponseInvocation(
            string invocationId,
            double attempt,
            global::System.Collections.Generic.IList<global::Vercel.SearchVercelCiLogsResponseInvocationTask> tasks,
            global::Vercel.SearchVercelCiLogsResponseInvocationSetup? setup)
        {
            this.InvocationId = invocationId ?? throw new global::System.ArgumentNullException(nameof(invocationId));
            this.Attempt = attempt;
            this.Tasks = tasks ?? throw new global::System.ArgumentNullException(nameof(tasks));
            this.Setup = setup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchVercelCiLogsResponseInvocation" /> class.
        /// </summary>
        public SearchVercelCiLogsResponseInvocation()
        {
        }

    }
}