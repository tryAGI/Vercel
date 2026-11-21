
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared1134f969ff3cc06cJobs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag-definitions-present")]
        public global::Vercel.AutoSDKShared1134f969ff3cc06cJobsFlagDefinitionsPresent? FlagDefinitionsPresent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health-check")]
        public global::Vercel.AutoSDKShared1134f969ff3cc06cJobsHealthCheck? HealthCheck { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lint")]
        public global::Vercel.AutoSDKShared1134f969ff3cc06cJobsLint? Lint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfe-config-present")]
        public global::Vercel.AutoSDKShared1134f969ff3cc06cJobsMfeConfigPresent? MfeConfigPresent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typecheck")]
        public global::Vercel.AutoSDKShared1134f969ff3cc06cJobsTypecheck? Typecheck { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared1134f969ff3cc06cJobs" /> class.
        /// </summary>
        /// <param name="flagDefinitionsPresent"></param>
        /// <param name="healthCheck"></param>
        /// <param name="lint"></param>
        /// <param name="mfeConfigPresent"></param>
        /// <param name="typecheck"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared1134f969ff3cc06cJobs(
            global::Vercel.AutoSDKShared1134f969ff3cc06cJobsFlagDefinitionsPresent? flagDefinitionsPresent,
            global::Vercel.AutoSDKShared1134f969ff3cc06cJobsHealthCheck? healthCheck,
            global::Vercel.AutoSDKShared1134f969ff3cc06cJobsLint? lint,
            global::Vercel.AutoSDKShared1134f969ff3cc06cJobsMfeConfigPresent? mfeConfigPresent,
            global::Vercel.AutoSDKShared1134f969ff3cc06cJobsTypecheck? typecheck)
        {
            this.FlagDefinitionsPresent = flagDefinitionsPresent;
            this.HealthCheck = healthCheck;
            this.Lint = lint;
            this.MfeConfigPresent = mfeConfigPresent;
            this.Typecheck = typecheck;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared1134f969ff3cc06cJobs" /> class.
        /// </summary>
        public AutoSDKShared1134f969ff3cc06cJobs()
        {
        }

    }
}