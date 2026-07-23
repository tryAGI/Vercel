
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant2ServiceVariant1TopicsVariant2Item
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Topic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retryAfterSeconds")]
        public double? RetryAfterSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initialDelaySeconds")]
        public double? InitialDelaySeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2ServiceVariant1TopicsVariant2Item" /> class.
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="retryAfterSeconds"></param>
        /// <param name="initialDelaySeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant2ServiceVariant1TopicsVariant2Item(
            string topic,
            double? retryAfterSeconds,
            double? initialDelaySeconds)
        {
            this.Topic = topic ?? throw new global::System.ArgumentNullException(nameof(topic));
            this.RetryAfterSeconds = retryAfterSeconds;
            this.InitialDelaySeconds = initialDelaySeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2ServiceVariant1TopicsVariant2Item" /> class.
        /// </summary>
        public GetDeploymentResponseVariant2ServiceVariant1TopicsVariant2Item()
        {
        }

    }
}