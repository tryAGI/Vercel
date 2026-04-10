
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default job configuration applied to new projects created in this team.
    /// </summary>
    public sealed partial class TeamDefaultProjectJobs
    {
        /// <summary>
        /// Default job configuration applied to new projects created in this team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lint")]
        public global::Vercel.TeamDefaultProjectJobsLint? Lint { get; set; }

        /// <summary>
        /// Default job configuration applied to new projects created in this team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typecheck")]
        public global::Vercel.TeamDefaultProjectJobsTypecheck? Typecheck { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDefaultProjectJobs" /> class.
        /// </summary>
        /// <param name="lint">
        /// Default job configuration applied to new projects created in this team.
        /// </param>
        /// <param name="typecheck">
        /// Default job configuration applied to new projects created in this team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamDefaultProjectJobs(
            global::Vercel.TeamDefaultProjectJobsLint? lint,
            global::Vercel.TeamDefaultProjectJobsTypecheck? typecheck)
        {
            this.Lint = lint;
            this.Typecheck = typecheck;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDefaultProjectJobs" /> class.
        /// </summary>
        public TeamDefaultProjectJobs()
        {
        }
    }
}