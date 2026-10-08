
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
    /// </summary>
    public sealed partial class AuthUserResourceConfigSecurity
    {
        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customRules")]
        public double? CustomRules { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipBlocks")]
        public double? IpBlocks { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipBypass")]
        public double? IpBypass { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimit")]
        public double? RateLimit { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securityLists")]
        public double? SecurityLists { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamLevelConditions")]
        public double? TeamLevelConditions { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamLevelRules")]
        public double? TeamLevelRules { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamLevelRulesets")]
        public double? TeamLevelRulesets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserResourceConfigSecurity" /> class.
        /// </summary>
        /// <param name="customRules">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="ipBlocks">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="ipBypass">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="rateLimit">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="securityLists">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="teamLevelConditions">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="teamLevelRules">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="teamLevelRulesets">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserResourceConfigSecurity(
            double? customRules,
            double? ipBlocks,
            double? ipBypass,
            double? rateLimit,
            double? securityLists,
            double? teamLevelConditions,
            double? teamLevelRules,
            double? teamLevelRulesets)
        {
            this.CustomRules = customRules;
            this.IpBlocks = ipBlocks;
            this.IpBypass = ipBypass;
            this.RateLimit = rateLimit;
            this.SecurityLists = securityLists;
            this.TeamLevelConditions = teamLevelConditions;
            this.TeamLevelRules = teamLevelRules;
            this.TeamLevelRulesets = teamLevelRulesets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserResourceConfigSecurity" /> class.
        /// </summary>
        public AuthUserResourceConfigSecurity()
        {
        }

    }
}