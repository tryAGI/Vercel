
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSecurityFirewallEventsSummaryResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockingIps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BlockingIps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byAction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> ByAction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byActionType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> ByActionType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challengingIps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ChallengingIps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Other { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallEventsSummaryResponse" /> class.
        /// </summary>
        /// <param name="blockingIps"></param>
        /// <param name="byAction"></param>
        /// <param name="byActionType"></param>
        /// <param name="challengingIps"></param>
        /// <param name="other"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSecurityFirewallEventsSummaryResponse(
            double blockingIps,
            global::System.Collections.Generic.Dictionary<string, double> byAction,
            global::System.Collections.Generic.Dictionary<string, double> byActionType,
            double challengingIps,
            double other,
            double total)
        {
            this.BlockingIps = blockingIps;
            this.ByAction = byAction ?? throw new global::System.ArgumentNullException(nameof(byAction));
            this.ByActionType = byActionType ?? throw new global::System.ArgumentNullException(nameof(byActionType));
            this.ChallengingIps = challengingIps;
            this.Other = other;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallEventsSummaryResponse" /> class.
        /// </summary>
        public GetSecurityFirewallEventsSummaryResponse()
        {
        }

    }
}