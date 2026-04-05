
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgoJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo Algo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Window { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitActionJsonConverter))]
        public global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimit" /> class.
        /// </summary>
        /// <param name="algo"></param>
        /// <param name="window"></param>
        /// <param name="limit"></param>
        /// <param name="keys"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimit(
            global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAlgo algo,
            double window,
            double limit,
            global::System.Collections.Generic.IList<string> keys,
            global::Vercel.PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimitAction? action)
        {
            this.Algo = algo;
            this.Window = window;
            this.Limit = limit;
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimit" /> class.
        /// </summary>
        public PutFirewallConfigResponseActiveRuleVariant1ActionMitigateRateLimit()
        {
        }
    }
}