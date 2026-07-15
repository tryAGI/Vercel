
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateFirewallRuleResponseRuleActionMitigate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimit")]
        public global::Vercel.GenerateFirewallRuleResponseRuleActionMitigateRateLimit? RateLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Vercel.GenerateFirewallRuleResponseRuleActionMitigateRedirect? Redirect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionDuration")]
        public string? ActionDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateFirewallRuleResponseRuleActionMitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="rateLimit"></param>
        /// <param name="redirect"></param>
        /// <param name="actionDuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateFirewallRuleResponseRuleActionMitigate(
            string action,
            global::Vercel.GenerateFirewallRuleResponseRuleActionMitigateRateLimit? rateLimit,
            global::Vercel.GenerateFirewallRuleResponseRuleActionMitigateRedirect? redirect,
            string? actionDuration)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.RateLimit = rateLimit;
            this.Redirect = redirect;
            this.ActionDuration = actionDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateFirewallRuleResponseRuleActionMitigate" /> class.
        /// </summary>
        public GenerateFirewallRuleResponseRuleActionMitigate()
        {
        }

    }
}