
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CancelDeploymentResponseProjectSettingsSpeedInsights
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledAt")]
        public double? EnabledAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledAt")]
        public double? DisabledAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceledAt")]
        public double? CanceledAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasData")]
        public bool? HasData { get; set; }

        /// <summary>
        /// When the first free (not Speed Insights Plus) production data point was observed, in ms. Set once by subscriber-analytics-events; projects that already had data before this field shipped get it backfilled on their next batch, so it reads "first free data point observed", not necessarily "first ever".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataReceivedAt")]
        public double? DataReceivedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseProjectSettingsSpeedInsights" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="enabledAt"></param>
        /// <param name="disabledAt"></param>
        /// <param name="canceledAt"></param>
        /// <param name="hasData"></param>
        /// <param name="dataReceivedAt">
        /// When the first free (not Speed Insights Plus) production data point was observed, in ms. Set once by subscriber-analytics-events; projects that already had data before this field shipped get it backfilled on their next batch, so it reads "first free data point observed", not necessarily "first ever".
        /// </param>
        /// <param name="paidAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseProjectSettingsSpeedInsights(
            string id,
            double? enabledAt,
            double? disabledAt,
            double? canceledAt,
            bool? hasData,
            double? dataReceivedAt,
            double? paidAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EnabledAt = enabledAt;
            this.DisabledAt = disabledAt;
            this.CanceledAt = canceledAt;
            this.HasData = hasData;
            this.DataReceivedAt = dataReceivedAt;
            this.PaidAt = paidAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseProjectSettingsSpeedInsights" /> class.
        /// </summary>
        public CancelDeploymentResponseProjectSettingsSpeedInsights()
        {
        }

    }
}