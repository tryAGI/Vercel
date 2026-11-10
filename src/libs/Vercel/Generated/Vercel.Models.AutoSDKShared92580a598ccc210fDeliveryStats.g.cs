
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Delivery health of a drain over the last 24 hours: `failing` when more than 5 delivery attempts and at least 1% of all attempts did not succeed, `healthy` otherwise, and `unknown` when there were no attempts or the stats could not be loaded.
    /// </summary>
    public sealed partial class AutoSDKShared92580a598ccc210fDeliveryStats
    {
        /// <summary>
        /// All delivery attempts in the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Attempts { get; set; }

        /// <summary>
        /// Delivery attempts that did not succeed in the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Failures { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared92580a598ccc210fDeliveryStatsStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared92580a598ccc210fDeliveryStatsState State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared92580a598ccc210fDeliveryStatsWindowJsonConverter))]
        public global::Vercel.AutoSDKShared92580a598ccc210fDeliveryStatsWindow Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared92580a598ccc210fDeliveryStats" /> class.
        /// </summary>
        /// <param name="attempts">
        /// All delivery attempts in the window.
        /// </param>
        /// <param name="failures">
        /// Delivery attempts that did not succeed in the window.
        /// </param>
        /// <param name="state"></param>
        /// <param name="window"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared92580a598ccc210fDeliveryStats(
            double attempts,
            double failures,
            global::Vercel.AutoSDKShared92580a598ccc210fDeliveryStatsState state,
            global::Vercel.AutoSDKShared92580a598ccc210fDeliveryStatsWindow window)
        {
            this.Attempts = attempts;
            this.Failures = failures;
            this.State = state;
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared92580a598ccc210fDeliveryStats" /> class.
        /// </summary>
        public AutoSDKShared92580a598ccc210fDeliveryStats()
        {
        }

    }
}