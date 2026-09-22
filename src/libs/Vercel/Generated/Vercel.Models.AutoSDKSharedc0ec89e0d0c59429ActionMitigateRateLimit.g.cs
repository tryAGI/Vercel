
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitActionJsonConverter))]
        public global::Vercel.AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAction? Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAlgoJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAlgo Algo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Keys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Limit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimit" /> class.
        /// </summary>
        /// <param name="algo"></param>
        /// <param name="keys"></param>
        /// <param name="limit"></param>
        /// <param name="window"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimit(
            global::Vercel.AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAlgo algo,
            global::System.Collections.Generic.IList<string> keys,
            double limit,
            double window,
            global::Vercel.AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAction? action)
        {
            this.Action = action;
            this.Algo = algo;
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
            this.Limit = limit;
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimit" /> class.
        /// </summary>
        public AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimit()
        {
        }

    }
}