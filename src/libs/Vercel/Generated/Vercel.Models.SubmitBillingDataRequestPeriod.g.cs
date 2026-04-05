
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Period for the billing cycle. The period end date cannot be older than 24 hours earlier than our current server's time.
    /// </summary>
    public sealed partial class SubmitBillingDataRequestPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitBillingDataRequestPeriod" /> class.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitBillingDataRequestPeriod(
            global::System.DateTime start,
            global::System.DateTime end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitBillingDataRequestPeriod" /> class.
        /// </summary>
        public SubmitBillingDataRequestPeriod()
        {
        }
    }
}