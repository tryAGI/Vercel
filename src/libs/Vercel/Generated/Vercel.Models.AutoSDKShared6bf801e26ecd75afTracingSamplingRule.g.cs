
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared6bf801e26ecd75afTracingSamplingRule
    {
        /// <summary>
        /// Which tracing destination this rule applies to. `internal` is the hidden Vercel production-tracing drain (internal delivery); `external` is any customer-configured drain. Derived from the owning drain's delivery type when project tracing is computed; absent on configs persisted before this field existed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6bf801e26ecd75afTracingSamplingRuleDestinationJsonConverter))]
        public global::Vercel.AutoSDKShared6bf801e26ecd75afTracingSamplingRuleDestination? Destination { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6bf801e26ecd75afTracingSamplingRuleEnvJsonConverter))]
        public global::Vercel.AutoSDKShared6bf801e26ecd75afTracingSamplingRuleEnv? Env { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestPath")]
        public string? RequestPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6bf801e26ecd75afTracingSamplingRule" /> class.
        /// </summary>
        /// <param name="rate"></param>
        /// <param name="destination">
        /// Which tracing destination this rule applies to. `internal` is the hidden Vercel production-tracing drain (internal delivery); `external` is any customer-configured drain. Derived from the owning drain's delivery type when project tracing is computed; absent on configs persisted before this field existed.
        /// </param>
        /// <param name="env"></param>
        /// <param name="requestPath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared6bf801e26ecd75afTracingSamplingRule(
            double rate,
            global::Vercel.AutoSDKShared6bf801e26ecd75afTracingSamplingRuleDestination? destination,
            global::Vercel.AutoSDKShared6bf801e26ecd75afTracingSamplingRuleEnv? env,
            string? requestPath)
        {
            this.Destination = destination;
            this.Env = env;
            this.Rate = rate;
            this.RequestPath = requestPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6bf801e26ecd75afTracingSamplingRule" /> class.
        /// </summary>
        public AutoSDKShared6bf801e26ecd75afTracingSamplingRule()
        {
        }

    }
}