
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateProjectResponseJobs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lint")]
        public global::Vercel.UpdateProjectResponseJobsLint? Lint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typecheck")]
        public global::Vercel.UpdateProjectResponseJobsTypecheck? Typecheck { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfe-config-present")]
        public global::Vercel.UpdateProjectResponseJobsMfeConfigPresent? MfeConfigPresent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseJobs" /> class.
        /// </summary>
        /// <param name="lint"></param>
        /// <param name="typecheck"></param>
        /// <param name="mfeConfigPresent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponseJobs(
            global::Vercel.UpdateProjectResponseJobsLint? lint,
            global::Vercel.UpdateProjectResponseJobsTypecheck? typecheck,
            global::Vercel.UpdateProjectResponseJobsMfeConfigPresent? mfeConfigPresent)
        {
            this.Lint = lint;
            this.Typecheck = typecheck;
            this.MfeConfigPresent = mfeConfigPresent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseJobs" /> class.
        /// </summary>
        public UpdateProjectResponseJobs()
        {
        }

    }
}