
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction Action { get; set; }

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
        public global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErl? Erl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_headers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateLogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="ruleId"></param>
        /// <param name="ttl"></param>
        /// <param name="erl"></param>
        /// <param name="logHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigate(
            global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction action,
            string ruleId,
            double? ttl,
            global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErl? erl,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateLogHeaders?>? logHeaders)
        {
            this.Action = action;
            this.RuleId = ruleId ?? throw new global::System.ArgumentNullException(nameof(ruleId));
            this.Ttl = ttl;
            this.Erl = erl;
            this.LogHeaders = logHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigate" /> class.
        /// </summary>
        public GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigate()
        {
        }
    }
}