
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitPrepaymentBalancesRequest
    {
        /// <summary>
        /// Server time of your integration, used to determine the most recent data for race conditions &amp; updates. Only the latest usage data for a given day, week, and month will be kept.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.SubmitPrepaymentBalancesRequestBalance> Balances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitPrepaymentBalancesRequest" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Server time of your integration, used to determine the most recent data for race conditions &amp; updates. Only the latest usage data for a given day, week, and month will be kept.
        /// </param>
        /// <param name="balances"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitPrepaymentBalancesRequest(
            global::System.DateTime timestamp,
            global::System.Collections.Generic.IList<global::Vercel.SubmitPrepaymentBalancesRequestBalance> balances)
        {
            this.Timestamp = timestamp;
            this.Balances = balances ?? throw new global::System.ArgumentNullException(nameof(balances));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitPrepaymentBalancesRequest" /> class.
        /// </summary>
        public SubmitPrepaymentBalancesRequest()
        {
        }
    }
}