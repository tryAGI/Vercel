
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9a99a7cde55f3566RulesetsRateLimit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared9a99a7cde55f3566RulesetsRateLimitAlgoJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared9a99a7cde55f3566RulesetsRateLimitAlgo Algo { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared9a99a7cde55f3566RulesetsRateLimit" /> class.
        /// </summary>
        /// <param name="algo"></param>
        /// <param name="keys"></param>
        /// <param name="limit"></param>
        /// <param name="window"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9a99a7cde55f3566RulesetsRateLimit(
            global::Vercel.AutoSDKShared9a99a7cde55f3566RulesetsRateLimitAlgo algo,
            global::System.Collections.Generic.IList<string> keys,
            double limit,
            double window)
        {
            this.Algo = algo;
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
            this.Limit = limit;
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9a99a7cde55f3566RulesetsRateLimit" /> class.
        /// </summary>
        public AutoSDKShared9a99a7cde55f3566RulesetsRateLimit()
        {
        }

    }
}