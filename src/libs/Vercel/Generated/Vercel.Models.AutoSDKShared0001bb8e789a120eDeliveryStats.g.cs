
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Delivery health of a drain over the last 24 hours, counted on finished deliveries (a delivery saved by an automatic retry counts once, as delivered): `failing` when more than 5 deliveries failed and they are at least 1% of all finished deliveries, `healthy` otherwise, and `unknown` when no delivery finished in the window.
    /// </summary>
    public sealed partial class AutoSDKShared0001bb8e789a120eDeliveryStats
    {
        /// <summary>
        /// Finished deliveries in the window: delivered plus finally failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Attempts { get; set; }

        /// <summary>
        /// Deliveries that finally failed in the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Failures { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0001bb8e789a120eDeliveryStatsStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared0001bb8e789a120eDeliveryStatsState State { get; set; }

        /// <summary>
        /// Deliveries that finally failed in the window, after any automatic retries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalFailedDeliveries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalFailedDeliveries { get; set; }

        /// <summary>
        /// Deliveries whose first try failed and were scheduled for an automatic retry in the window, whatever their final outcome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRetriedDeliveries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalRetriedDeliveries { get; set; }

        /// <summary>
        /// Deliveries delivered in the window, on the first try or after automatic retries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSuccessfulDeliveries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalSuccessfulDeliveries { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0001bb8e789a120eDeliveryStatsWindowJsonConverter))]
        public global::Vercel.AutoSDKShared0001bb8e789a120eDeliveryStatsWindow Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0001bb8e789a120eDeliveryStats" /> class.
        /// </summary>
        /// <param name="attempts">
        /// Finished deliveries in the window: delivered plus finally failed.
        /// </param>
        /// <param name="failures">
        /// Deliveries that finally failed in the window.
        /// </param>
        /// <param name="state"></param>
        /// <param name="totalFailedDeliveries">
        /// Deliveries that finally failed in the window, after any automatic retries.
        /// </param>
        /// <param name="totalRetriedDeliveries">
        /// Deliveries whose first try failed and were scheduled for an automatic retry in the window, whatever their final outcome.
        /// </param>
        /// <param name="totalSuccessfulDeliveries">
        /// Deliveries delivered in the window, on the first try or after automatic retries.
        /// </param>
        /// <param name="window"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0001bb8e789a120eDeliveryStats(
            double attempts,
            double failures,
            global::Vercel.AutoSDKShared0001bb8e789a120eDeliveryStatsState state,
            double totalFailedDeliveries,
            double totalRetriedDeliveries,
            double totalSuccessfulDeliveries,
            global::Vercel.AutoSDKShared0001bb8e789a120eDeliveryStatsWindow window)
        {
            this.Attempts = attempts;
            this.Failures = failures;
            this.State = state;
            this.TotalFailedDeliveries = totalFailedDeliveries;
            this.TotalRetriedDeliveries = totalRetriedDeliveries;
            this.TotalSuccessfulDeliveries = totalSuccessfulDeliveries;
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0001bb8e789a120eDeliveryStats" /> class.
        /// </summary>
        public AutoSDKShared0001bb8e789a120eDeliveryStats()
        {
        }

    }
}