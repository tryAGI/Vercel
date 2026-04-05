
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutFirewallConfigResponseActiveRuleVariant1ActionMitigate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimit")]
        public global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimit? RateLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRedirect? Redirect { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateLogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveRuleVariant1ActionMitigate" /> class.
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
        public PutFirewallConfigResponseActiveRuleVariant1ActionMitigate(
            global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateAction action,
            global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimit? rateLimit,
            global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRedirect? redirect,
            string? actionDuration,
            bool? bypassSystem,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateLogHeaders?>? logHeaders)
        {
            this.Action = action;
            this.RateLimit = rateLimit;
            this.Redirect = redirect;
            this.ActionDuration = actionDuration;
            this.BypassSystem = bypassSystem;
            this.LogHeaders = logHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveRuleVariant1ActionMitigate" /> class.
        /// </summary>
        public PutFirewallConfigResponseActiveRuleVariant1ActionMitigate()
        {
        }
    }
}