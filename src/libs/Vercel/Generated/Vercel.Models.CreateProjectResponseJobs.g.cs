
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectResponseJobs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lint")]
        public global::Vercel.CreateProjectResponseJobsLint? Lint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typecheck")]
        public global::Vercel.CreateProjectResponseJobsTypecheck? Typecheck { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfe-config-present")]
        public global::Vercel.CreateProjectResponseJobsMfeConfigPresent? MfeConfigPresent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseJobs" /> class.
        /// </summary>
        /// <param name="lint"></param>
        /// <param name="typecheck"></param>
        /// <param name="mfeConfigPresent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectResponseJobs(
            global::Vercel.CreateProjectResponseJobsLint? lint,
            global::Vercel.CreateProjectResponseJobsTypecheck? typecheck,
            global::Vercel.CreateProjectResponseJobsMfeConfigPresent? mfeConfigPresent)
        {
            this.Lint = lint;
            this.Typecheck = typecheck;
            this.MfeConfigPresent = mfeConfigPresent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseJobs" /> class.
        /// </summary>
        public CreateProjectResponseJobs()
        {
        }

    }
}