
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Delivery health of a drain over the last 24 hours: `failing` when more than 5 delivery attempts and at least 1% of all attempts did not succeed, `healthy` otherwise, and `unknown` when there were no attempts or the stats could not be loaded.
    /// </summary>
    public sealed partial class AutoSDKShareda861c3cb40ec56dcDeliveryStats
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda861c3cb40ec56dcDeliveryStatsStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryStatsState State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda861c3cb40ec56dcDeliveryStatsWindowJsonConverter))]
        public global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryStatsWindow Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda861c3cb40ec56dcDeliveryStats" /> class.
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
        public AutoSDKShareda861c3cb40ec56dcDeliveryStats(
            double attempts,
            double failures,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryStatsState state,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryStatsWindow window)
        {
            this.Attempts = attempts;
            this.Failures = failures;
            this.State = state;
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda861c3cb40ec56dcDeliveryStats" /> class.
        /// </summary>
        public AutoSDKShareda861c3cb40ec56dcDeliveryStats()
        {
        }

    }
}