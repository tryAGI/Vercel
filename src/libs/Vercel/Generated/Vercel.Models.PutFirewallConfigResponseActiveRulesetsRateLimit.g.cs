
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PutFirewallConfigResponseActiveRulesetsRateLimit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PutFirewallConfigResponseActiveRulesetsRateLimitActionJsonConverter))]
        public global::Vercel.PutFirewallConfigResponseActiveRulesetsRateLimitAction? Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PutFirewallConfigResponseActiveRulesetsRateLimitAlgoJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveRulesetsRateLimitAlgo Algo { get; set; }

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
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveRulesetsRateLimit" /> class.
        /// </summary>
        /// <param name="algo"></param>
        /// <param name="keys"></param>
        /// <param name="limit"></param>
        /// <param name="window"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigResponseActiveRulesetsRateLimit(
            global::Vercel.PutFirewallConfigResponseActiveRulesetsRateLimitAlgo algo,
            global::System.Collections.Generic.IList<string> keys,
            double limit,
            double window,
            global::Vercel.PutFirewallConfigResponseActiveRulesetsRateLimitAction? action)
        {
            this.Action = action;
            this.Algo = algo;
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
            this.Limit = limit;
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveRulesetsRateLimit" /> class.
        /// </summary>
        public PutFirewallConfigResponseActiveRulesetsRateLimit()
        {
        }

    }
}