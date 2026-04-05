
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutFirewallConfigRequestRuleActionMitigate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PutFirewallConfigRequestRuleActionMitigateActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigRequestRuleActionMitigateAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1, object>))]
        public global::Vercel.AnyOf<global::Vercel.PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1, object>? RateLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.PutFirewallConfigRequestRuleActionMitigateRedirectVariant1, object>))]
        public global::Vercel.AnyOf<global::Vercel.PutFirewallConfigRequestRuleActionMitigateRedirectVariant1, object>? Redirect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionDuration")]
        public string? ActionDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bypassSystem")]
        public bool? BypassSystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logHeaders")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? LogHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigRequestRuleActionMitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="rateLimit"></param>
        /// <param name="redirect"></param>
        /// <param name="actionDuration"></param>
        /// <param name="bypassSystem"></param>
        /// <param name="logHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigRequestRuleActionMitigate(
            global::Vercel.PutFirewallConfigRequestRuleActionMitigateAction action,
            global::Vercel.AnyOf<global::Vercel.PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1, object>? rateLimit,
            global::Vercel.AnyOf<global::Vercel.PutFirewallConfigRequestRuleActionMitigateRedirectVariant1, object>? redirect,
            string? actionDuration,
            bool? bypassSystem,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? logHeaders)
        {
            this.Action = action;
            this.RateLimit = rateLimit;
            this.Redirect = redirect;
            this.ActionDuration = actionDuration;
            this.BypassSystem = bypassSystem;
            this.LogHeaders = logHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigRequestRuleActionMitigate" /> class.
        /// </summary>
        public PutFirewallConfigRequestRuleActionMitigate()
        {
        }
    }
}