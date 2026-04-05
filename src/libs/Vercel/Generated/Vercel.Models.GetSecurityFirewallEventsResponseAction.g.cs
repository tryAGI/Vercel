
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
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isActive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_ip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallEventsResponseAction" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="isActive"></param>
        /// <param name="actionType"></param>
        /// <param name="host"></param>
        /// <param name="publicIp"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSecurityFirewallEventsResponseAction(
            string startTime,
            string endTime,
            bool isActive,
            string actionType,
            string host,
            string publicIp,
            double count)
        {
            this.StartTime = startTime ?? throw new global::System.ArgumentNullException(nameof(startTime));
            this.EndTime = endTime ?? throw new global::System.ArgumentNullException(nameof(endTime));
            this.IsActive = isActive;
            this.ActionType = actionType ?? throw new global::System.ArgumentNullException(nameof(actionType));
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.PublicIp = publicIp ?? throw new global::System.ArgumentNullException(nameof(publicIp));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallEventsResponseAction" /> class.
        /// </summary>
        public GetSecurityFirewallEventsResponseAction()
        {
        }
    }
}