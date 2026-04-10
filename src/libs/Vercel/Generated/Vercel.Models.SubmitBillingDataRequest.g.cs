
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitBillingDataRequest
    {
        /// <summary>
        /// Server time of your integration, used to determine the most recent data for race conditions &amp; updates. Only the latest usage data for a given day, week, and month will be kept.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// End of Day, the UTC datetime for when the end of the billing/usage day is in UTC time. This tells us which day the usage data is for, and also allows for your "end of day" to be different from UTC 00:00:00. eod must be within the period dates, and cannot be older than 24h earlier from our server's current time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eod")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Eod { get; set; }

        /// <summary>
        /// Period for the billing cycle. The period end date cannot be older than 24 hours earlier than our current server's time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.SubmitBillingDataRequestPeriod Period { get; set; }

        /// <summary>
        /// Billing data (interim invoicing data).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingItem>, global::Vercel.SubmitBillingDataRequestBilling>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingItem>, global::Vercel.SubmitBillingDataRequestBilling> Billing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestUsageItem> Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitBillingDataRequest" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Server time of your integration, used to determine the most recent data for race conditions &amp; updates. Only the latest usage data for a given day, week, and month will be kept.
        /// </param>
        /// <param name="eod">
        /// End of Day, the UTC datetime for when the end of the billing/usage day is in UTC time. This tells us which day the usage data is for, and also allows for your "end of day" to be different from UTC 00:00:00. eod must be within the period dates, and cannot be older than 24h earlier from our server's current time.
        /// </param>
        /// <param name="period">
        /// Period for the billing cycle. The period end date cannot be older than 24 hours earlier than our current server's time.
        /// </param>
        /// <param name="billing">
        /// Billing data (interim invoicing data).
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitBillingDataRequest(
            global::System.DateTime timestamp,
            global::System.DateTime eod,
            global::Vercel.SubmitBillingDataRequestPeriod period,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingItem>, global::Vercel.SubmitBillingDataRequestBilling> billing,
            global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestUsageItem> usage)
        {
            this.Timestamp = timestamp;
            this.Eod = eod;
            this.Period = period ?? throw new global::System.ArgumentNullException(nameof(period));
            this.Billing = billing;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitBillingDataRequest" /> class.
        /// </summary>
        public SubmitBillingDataRequest()
        {
        }
    }
}