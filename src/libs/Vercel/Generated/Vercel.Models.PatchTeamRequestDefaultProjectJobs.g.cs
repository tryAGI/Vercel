
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default job configuration applied to new projects created in this team.
    /// </summary>
    public sealed partial class PatchTeamRequestDefaultProjectJobs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lint")]
        public global::Vercel.PatchTeamRequestDefaultProjectJobsLint? Lint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typecheck")]
        public global::Vercel.PatchTeamRequestDefaultProjectJobsTypecheck? Typecheck { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDefaultProjectJobs" /> class.
        /// </summary>
        /// <param name="lint"></param>
        /// <param name="typecheck"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestDefaultProjectJobs(
            global::Vercel.PatchTeamRequestDefaultProjectJobsLint? lint,
            global::Vercel.PatchTeamRequestDefaultProjectJobsTypecheck? typecheck)
        {
            this.Lint = lint;
            this.Typecheck = typecheck;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDefaultProjectJobs" /> class.
        /// </summary>
        public PatchTeamRequestDefaultProjectJobs()
        {
        }
    }
}