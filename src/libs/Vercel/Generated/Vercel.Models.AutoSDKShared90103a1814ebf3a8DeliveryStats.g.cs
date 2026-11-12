
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Delivery health of a drain over the last 24 hours, counted on finished deliveries (a delivery saved by an automatic retry counts once, as delivered): `failing` when more than 5 deliveries failed and they are at least 1% of all finished deliveries, `healthy` otherwise, and `unknown` when no delivery finished in the window.
    /// </summary>
    public sealed partial class AutoSDKShared90103a1814ebf3a8DeliveryStats
    {
        /// <summary>
        /// Finished deliveries in the window: delivered plus finally failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Attempts { get; set; }

        /// <summary>
        /// Deliveries that finally failed in the window, after any automatic retries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Failures { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared90103a1814ebf3a8DeliveryStatsStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared90103a1814ebf3a8DeliveryStatsState State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared90103a1814ebf3a8DeliveryStatsWindowJsonConverter))]
        public global::Vercel.AutoSDKShared90103a1814ebf3a8DeliveryStatsWindow Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared90103a1814ebf3a8DeliveryStats" /> class.
        /// </summary>
        /// <param name="attempts">
        /// Finished deliveries in the window: delivered plus finally failed.
        /// </param>
        /// <param name="failures">
        /// Deliveries that finally failed in the window, after any automatic retries.
        /// </param>
        /// <param name="state"></param>
        /// <param name="window"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared90103a1814ebf3a8DeliveryStats(
            double attempts,
            double failures,
            global::Vercel.AutoSDKShared90103a1814ebf3a8DeliveryStatsState state,
            global::Vercel.AutoSDKShared90103a1814ebf3a8DeliveryStatsWindow window)
        {
            this.Attempts = attempts;
            this.Failures = failures;
            this.State = state;
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared90103a1814ebf3a8DeliveryStats" /> class.
        /// </summary>
        public AutoSDKShared90103a1814ebf3a8DeliveryStats()
        {
        }

    }
}