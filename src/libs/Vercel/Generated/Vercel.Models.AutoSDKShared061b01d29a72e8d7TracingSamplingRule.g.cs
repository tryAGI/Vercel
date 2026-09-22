
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared061b01d29a72e8d7TracingSamplingRule
    {
        /// <summary>
        /// Which tracing destination this rule applies to. `internal` is the hidden Vercel production-tracing drain (internal delivery); `external` is any customer-configured drain. Derived from the owning drain's delivery type when project tracing is computed; absent on configs persisted before this field existed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared061b01d29a72e8d7TracingSamplingRuleDestinationJsonConverter))]
        public global::Vercel.AutoSDKShared061b01d29a72e8d7TracingSamplingRuleDestination? Destination { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared061b01d29a72e8d7TracingSamplingRuleEnvJsonConverter))]
        public global::Vercel.AutoSDKShared061b01d29a72e8d7TracingSamplingRuleEnv? Env { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared061b01d29a72e8d7TracingSamplingRule" /> class.
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
        public AutoSDKShared061b01d29a72e8d7TracingSamplingRule(
            double rate,
            global::Vercel.AutoSDKShared061b01d29a72e8d7TracingSamplingRuleDestination? destination,
            global::Vercel.AutoSDKShared061b01d29a72e8d7TracingSamplingRuleEnv? env,
            string? requestPath)
        {
            this.Destination = destination;
            this.Env = env;
            this.Rate = rate;
            this.RequestPath = requestPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared061b01d29a72e8d7TracingSamplingRule" /> class.
        /// </summary>
        public AutoSDKShared061b01d29a72e8d7TracingSamplingRule()
        {
        }

    }
}