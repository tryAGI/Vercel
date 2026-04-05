
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserResourceConfigSecurity(
            double? customRules,
            double? ipBlocks,
            double? ipBypass,
            double? rateLimit)
        {
            this.CustomRules = customRules;
            this.IpBlocks = ipBlocks;
            this.IpBypass = ipBypass;
            this.RateLimit = rateLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserResourceConfigSecurity" /> class.
        /// </summary>
        public AuthUserResourceConfigSecurity()
        {
        }
    }
}