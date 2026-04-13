
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant116NewOwnerResourceConfigSecurity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customRules")]
        public double? CustomRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipBlocks")]
        public double? IpBlocks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipBypass")]
        public double? IpBypass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimit")]
        public double? RateLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116NewOwnerResourceConfigSecurity" /> class.
        /// </summary>
        /// <param name="customRules"></param>
        /// <param name="ipBlocks"></param>
        /// <param name="ipBypass"></param>
        /// <param name="rateLimit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant116NewOwnerResourceConfigSecurity(
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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116NewOwnerResourceConfigSecurity" /> class.
        /// </summary>
        public UserEventPayloadVariant116NewOwnerResourceConfigSecurity()
        {
        }
    }
}