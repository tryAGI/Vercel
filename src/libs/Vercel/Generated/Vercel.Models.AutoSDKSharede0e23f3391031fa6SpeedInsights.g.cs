
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede0e23f3391031fa6SpeedInsights
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceledAt")]
        public double? CanceledAt { get; set; }

        /// <summary>
        /// When the first free (not Speed Insights Plus) production data point was observed, in ms. Set once by subscriber-analytics-events; projects that already had data before this field shipped get it backfilled on their next batch, so it reads "first free data point observed", not necessarily "first ever".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataReceivedAt")]
        public double? DataReceivedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledAt")]
        public double? DisabledAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledAt")]
        public double? EnabledAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasData")]
        public bool? HasData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paidAt")]
        public double? PaidAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede0e23f3391031fa6SpeedInsights" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="canceledAt"></param>
        /// <param name="dataReceivedAt">
        /// When the first free (not Speed Insights Plus) production data point was observed, in ms. Set once by subscriber-analytics-events; projects that already had data before this field shipped get it backfilled on their next batch, so it reads "first free data point observed", not necessarily "first ever".
        /// </param>
        /// <param name="disabledAt"></param>
        /// <param name="enabledAt"></param>
        /// <param name="hasData"></param>
        /// <param name="paidAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede0e23f3391031fa6SpeedInsights(
            string id,
            double? canceledAt,
            double? dataReceivedAt,
            double? disabledAt,
            double? enabledAt,
            bool? hasData,
            double? paidAt)
        {
            this.CanceledAt = canceledAt;
            this.DataReceivedAt = dataReceivedAt;
            this.DisabledAt = disabledAt;
            this.EnabledAt = enabledAt;
            this.HasData = hasData;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PaidAt = paidAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede0e23f3391031fa6SpeedInsights" /> class.
        /// </summary>
        public AutoSDKSharede0e23f3391031fa6SpeedInsights()
        {
        }

    }
}