
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSecurityFirewallEventsResponseAction
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
        [global::System.Text.Json.Serialization.JsonPropertyName("action_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isActive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_ip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicIp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleId")]
        public string? RuleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleName")]
        public string? RuleName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallEventsResponseAction" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="actionType"></param>
        /// <param name="count"></param>
        /// <param name="endTime"></param>
        /// <param name="host"></param>
        /// <param name="isActive"></param>
        /// <param name="publicIp"></param>
        /// <param name="startTime"></param>
        /// <param name="ruleId"></param>
        /// <param name="ruleName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSecurityFirewallEventsResponseAction(
            string action,
            string actionType,
            double count,
            string endTime,
            string host,
            bool isActive,
            string publicIp,
            string startTime,
            string? ruleId,
            string? ruleName)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.ActionType = actionType ?? throw new global::System.ArgumentNullException(nameof(actionType));
            this.Count = count;
            this.EndTime = endTime ?? throw new global::System.ArgumentNullException(nameof(endTime));
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.IsActive = isActive;
            this.PublicIp = publicIp ?? throw new global::System.ArgumentNullException(nameof(publicIp));
            this.RuleId = ruleId;
            this.RuleName = ruleName;
            this.StartTime = startTime ?? throw new global::System.ArgumentNullException(nameof(startTime));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallEventsResponseAction" /> class.
        /// </summary>
        public GetSecurityFirewallEventsResponseAction()
        {
        }

    }
}