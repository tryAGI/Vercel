
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public double? Ttl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("erl")]
        public global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateErl? Erl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_headers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateLogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="ruleId"></param>
        /// <param name="ttl"></param>
        /// <param name="erl"></param>
        /// <param name="logHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigate(
            global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction action,
            string ruleId,
            double? ttl,
            global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateErl? erl,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateLogHeaders?>? logHeaders)
        {
            this.Action = action;
            this.RuleId = ruleId ?? throw new global::System.ArgumentNullException(nameof(ruleId));
            this.Ttl = ttl;
            this.Erl = erl;
            this.LogHeaders = logHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigate" /> class.
        /// </summary>
        public GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigate()
        {
        }
    }
}