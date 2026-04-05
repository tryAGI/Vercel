
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutFirewallConfigResponseActiveRuleVariant2ActionMitigate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PutFirewallConfigResponseActiveRuleVariant2ActionMitigateActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimit")]
        public global::Vercel.PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimit? RateLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Vercel.PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRedirect? Redirect { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.PutFirewallConfigResponseActiveRuleVariant2ActionMitigateLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.PutFirewallConfigResponseActiveRuleVariant2ActionMitigateLogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveRuleVariant2ActionMitigate" /> class.
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
        public PutFirewallConfigResponseActiveRuleVariant2ActionMitigate(
            global::Vercel.PutFirewallConfigResponseActiveRuleVariant2ActionMitigateAction action,
            global::Vercel.PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRateLimit? rateLimit,
            global::Vercel.PutFirewallConfigResponseActiveRuleVariant2ActionMitigateRedirect? redirect,
            string? actionDuration,
            bool? bypassSystem,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.PutFirewallConfigResponseActiveRuleVariant2ActionMitigateLogHeaders?>? logHeaders)
        {
            this.Action = action;
            this.RateLimit = rateLimit;
            this.Redirect = redirect;
            this.ActionDuration = actionDuration;
            this.BypassSystem = bypassSystem;
            this.LogHeaders = logHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveRuleVariant2ActionMitigate" /> class.
        /// </summary>
        public PutFirewallConfigResponseActiveRuleVariant2ActionMitigate()
        {
        }
    }
}