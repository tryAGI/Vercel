
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitBillingDataRequestUsageItem
    {
        /// <summary>
        /// Partner's resource ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// Metric name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///               Type of the metric.<br/>
        ///               - total: measured total value, such as Database size<br/>
        ///               - interval: usage during the period, such as i/o or number of queries.<br/>
        ///               - rate: rate of usage, such as queries per second.<br/>
        ///             
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.SubmitBillingDataRequestUsageItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.SubmitBillingDataRequestUsageItemType Type { get; set; }

        /// <summary>
        /// Metric units. Example: "GB"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Units { get; set; }

        /// <summary>
        /// Metric value for the day. Could be a final or an interim value for the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dayValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DayValue { get; set; }

        /// <summary>
        /// Metric value for the billing period. Could be a final or an interim value for the period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PeriodValue { get; set; }

        /// <summary>
        /// The limit value of the metric for a billing period, if a limit is defined by the plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planValue")]
        public double? PlanValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitBillingDataRequestUsageItem" /> class.
        /// </summary>
        /// <param name="name">
        /// Metric name.
        /// </param>
        /// <param name="type">
        ///               Type of the metric.<br/>
        ///               - total: measured total value, such as Database size<br/>
        ///               - interval: usage during the period, such as i/o or number of queries.<br/>
        ///               - rate: rate of usage, such as queries per second.<br/>
        ///             
        /// </param>
        /// <param name="units">
        /// Metric units. Example: "GB"
        /// </param>
        /// <param name="dayValue">
        /// Metric value for the day. Could be a final or an interim value for the day.
        /// </param>
        /// <param name="periodValue">
        /// Metric value for the billing period. Could be a final or an interim value for the period.
        /// </param>
        /// <param name="resourceId">
        /// Partner's resource ID.
        /// </param>
        /// <param name="planValue">
        /// The limit value of the metric for a billing period, if a limit is defined by the plan.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitBillingDataRequestUsageItem(
            string name,
            global::Vercel.SubmitBillingDataRequestUsageItemType type,
            string units,
            double dayValue,
            double periodValue,
            string? resourceId,
            double? planValue)
        {
            this.ResourceId = resourceId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Units = units ?? throw new global::System.ArgumentNullException(nameof(units));
            this.DayValue = dayValue;
            this.PeriodValue = periodValue;
            this.PlanValue = planValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitBillingDataRequestUsageItem" /> class.
        /// </summary>
        public SubmitBillingDataRequestUsageItem()
        {
        }
    }
}