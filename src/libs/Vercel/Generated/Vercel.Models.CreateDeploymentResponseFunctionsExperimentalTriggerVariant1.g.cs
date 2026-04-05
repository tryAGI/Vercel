
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Queue trigger input event for v1beta (from vercel.json config). Requires explicit consumer name.
    /// </summary>
    public sealed partial class CreateDeploymentResponseFunctionsExperimentalTriggerVariant1
    {
        /// <summary>
        /// Event type - must be "queue/v1beta" (REQUIRED)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseFunctionsExperimentalTriggerVariant1TypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseFunctionsExperimentalTriggerVariant1Type Type { get; set; }

        /// <summary>
        /// Name of the consumer group for this trigger (REQUIRED)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Consumer { get; set; }

        /// <summary>
        /// Name of the queue topic to consume from (REQUIRED)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Topic { get; set; }

        /// <summary>
        /// Maximum number of delivery attempts for message processing (OPTIONAL) This represents the total number of times a message can be delivered, not the number of retries. Must be at least 1 if specified. Behavior when not specified depends on the server's default configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDeliveries")]
        public double? MaxDeliveries { get; set; }

        /// <summary>
        /// Delay in seconds before retrying failed executions (OPTIONAL) Behavior when not specified depends on the server's default configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retryAfterSeconds")]
        public double? RetryAfterSeconds { get; set; }

        /// <summary>
        /// Initial delay in seconds before first execution attempt (OPTIONAL) Must be 0 or greater. Use 0 for no initial delay. Behavior when not specified depends on the server's default configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initialDelaySeconds")]
        public double? InitialDelaySeconds { get; set; }

        /// <summary>
        /// Maximum number of concurrent executions for this consumer (OPTIONAL) Must be at least 1 if specified. Behavior when not specified depends on the server's default configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxConcurrency")]
        public double? MaxConcurrency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseFunctionsExperimentalTriggerVariant1" /> class.
        /// </summary>
        /// <param name="consumer">
        /// Name of the consumer group for this trigger (REQUIRED)
        /// </param>
        /// <param name="topic">
        /// Name of the queue topic to consume from (REQUIRED)
        /// </param>
        /// <param name="type">
        /// Event type - must be "queue/v1beta" (REQUIRED)
        /// </param>
        /// <param name="maxDeliveries">
        /// Maximum number of delivery attempts for message processing (OPTIONAL) This represents the total number of times a message can be delivered, not the number of retries. Must be at least 1 if specified. Behavior when not specified depends on the server's default configuration.
        /// </param>
        /// <param name="retryAfterSeconds">
        /// Delay in seconds before retrying failed executions (OPTIONAL) Behavior when not specified depends on the server's default configuration.
        /// </param>
        /// <param name="initialDelaySeconds">
        /// Initial delay in seconds before first execution attempt (OPTIONAL) Must be 0 or greater. Use 0 for no initial delay. Behavior when not specified depends on the server's default configuration.
        /// </param>
        /// <param name="maxConcurrency">
        /// Maximum number of concurrent executions for this consumer (OPTIONAL) Must be at least 1 if specified. Behavior when not specified depends on the server's default configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseFunctionsExperimentalTriggerVariant1(
            string consumer,
            string topic,
            global::Vercel.CreateDeploymentResponseFunctionsExperimentalTriggerVariant1Type type,
            double? maxDeliveries,
            double? retryAfterSeconds,
            double? initialDelaySeconds,
            double? maxConcurrency)
        {
            this.Type = type;
            this.Consumer = consumer ?? throw new global::System.ArgumentNullException(nameof(consumer));
            this.Topic = topic ?? throw new global::System.ArgumentNullException(nameof(topic));
            this.MaxDeliveries = maxDeliveries;
            this.RetryAfterSeconds = retryAfterSeconds;
            this.InitialDelaySeconds = initialDelaySeconds;
            this.MaxConcurrency = maxConcurrency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseFunctionsExperimentalTriggerVariant1" /> class.
        /// </summary>
        public CreateDeploymentResponseFunctionsExperimentalTriggerVariant1()
        {
        }
    }
}