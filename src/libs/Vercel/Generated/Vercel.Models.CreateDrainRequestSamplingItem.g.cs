
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDrainRequestSamplingItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Sampling rate from 0 to 1 (e.g., 0.1 for 10%)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rate { get; set; }

        /// <summary>
        /// Environment to apply sampling to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainRequestSamplingItemEnvJsonConverter))]
        public global::Vercel.CreateDrainRequestSamplingItemEnv? Env { get; set; }

        /// <summary>
        /// Request path prefix to apply the sampling rule to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestPath")]
        public string? RequestPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainRequestSamplingItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="rate">
        /// Sampling rate from 0 to 1 (e.g., 0.1 for 10%)
        /// </param>
        /// <param name="env">
        /// Environment to apply sampling to
        /// </param>
        /// <param name="requestPath">
        /// Request path prefix to apply the sampling rule to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDrainRequestSamplingItem(
            string type,
            double rate,
            global::Vercel.CreateDrainRequestSamplingItemEnv? env,
            string? requestPath)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Rate = rate;
            this.Env = env;
            this.RequestPath = requestPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainRequestSamplingItem" /> class.
        /// </summary>
        public CreateDrainRequestSamplingItem()
        {
        }
    }
}