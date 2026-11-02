
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedf5934c240f4382f7Jobs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag-definitions-present")]
        public global::Vercel.AutoSDKSharedf5934c240f4382f7JobsFlagDefinitionsPresent? FlagDefinitionsPresent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health-check")]
        public global::Vercel.AutoSDKSharedf5934c240f4382f7JobsHealthCheck? HealthCheck { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lint")]
        public global::Vercel.AutoSDKSharedf5934c240f4382f7JobsLint? Lint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfe-config-present")]
        public global::Vercel.AutoSDKSharedf5934c240f4382f7JobsMfeConfigPresent? MfeConfigPresent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typecheck")]
        public global::Vercel.AutoSDKSharedf5934c240f4382f7JobsTypecheck? Typecheck { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf5934c240f4382f7Jobs" /> class.
        /// </summary>
        /// <param name="flagDefinitionsPresent"></param>
        /// <param name="healthCheck"></param>
        /// <param name="lint"></param>
        /// <param name="mfeConfigPresent"></param>
        /// <param name="typecheck"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf5934c240f4382f7Jobs(
            global::Vercel.AutoSDKSharedf5934c240f4382f7JobsFlagDefinitionsPresent? flagDefinitionsPresent,
            global::Vercel.AutoSDKSharedf5934c240f4382f7JobsHealthCheck? healthCheck,
            global::Vercel.AutoSDKSharedf5934c240f4382f7JobsLint? lint,
            global::Vercel.AutoSDKSharedf5934c240f4382f7JobsMfeConfigPresent? mfeConfigPresent,
            global::Vercel.AutoSDKSharedf5934c240f4382f7JobsTypecheck? typecheck)
        {
            this.FlagDefinitionsPresent = flagDefinitionsPresent;
            this.HealthCheck = healthCheck;
            this.Lint = lint;
            this.MfeConfigPresent = mfeConfigPresent;
            this.Typecheck = typecheck;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf5934c240f4382f7Jobs" /> class.
        /// </summary>
        public AutoSDKSharedf5934c240f4382f7Jobs()
        {
        }

    }
}