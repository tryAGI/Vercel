
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedc1c2f92d02e0feb6Jobs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag-definitions-present")]
        public global::Vercel.AutoSDKSharedc1c2f92d02e0feb6JobsFlagDefinitionsPresent? FlagDefinitionsPresent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health-check")]
        public global::Vercel.AutoSDKSharedc1c2f92d02e0feb6JobsHealthCheck? HealthCheck { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lint")]
        public global::Vercel.AutoSDKSharedc1c2f92d02e0feb6JobsLint? Lint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfe-config-present")]
        public global::Vercel.AutoSDKSharedc1c2f92d02e0feb6JobsMfeConfigPresent? MfeConfigPresent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typecheck")]
        public global::Vercel.AutoSDKSharedc1c2f92d02e0feb6JobsTypecheck? Typecheck { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc1c2f92d02e0feb6Jobs" /> class.
        /// </summary>
        /// <param name="flagDefinitionsPresent"></param>
        /// <param name="healthCheck"></param>
        /// <param name="lint"></param>
        /// <param name="mfeConfigPresent"></param>
        /// <param name="typecheck"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedc1c2f92d02e0feb6Jobs(
            global::Vercel.AutoSDKSharedc1c2f92d02e0feb6JobsFlagDefinitionsPresent? flagDefinitionsPresent,
            global::Vercel.AutoSDKSharedc1c2f92d02e0feb6JobsHealthCheck? healthCheck,
            global::Vercel.AutoSDKSharedc1c2f92d02e0feb6JobsLint? lint,
            global::Vercel.AutoSDKSharedc1c2f92d02e0feb6JobsMfeConfigPresent? mfeConfigPresent,
            global::Vercel.AutoSDKSharedc1c2f92d02e0feb6JobsTypecheck? typecheck)
        {
            this.FlagDefinitionsPresent = flagDefinitionsPresent;
            this.HealthCheck = healthCheck;
            this.Lint = lint;
            this.MfeConfigPresent = mfeConfigPresent;
            this.Typecheck = typecheck;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc1c2f92d02e0feb6Jobs" /> class.
        /// </summary>
        public AutoSDKSharedc1c2f92d02e0feb6Jobs()
        {
        }

    }
}