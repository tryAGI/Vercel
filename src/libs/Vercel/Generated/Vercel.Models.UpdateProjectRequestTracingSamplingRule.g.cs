
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequestTracingSamplingRule
    {
        /// <summary>
        /// Sampling rate from 0 to 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rate { get; set; }

        /// <summary>
        /// Environment to apply sampling to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestTracingSamplingRuleEnvJsonConverter))]
        public global::Vercel.UpdateProjectRequestTracingSamplingRuleEnv? Env { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTracingSamplingRule" /> class.
        /// </summary>
        /// <param name="rate">
        /// Sampling rate from 0 to 1
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
        public UpdateProjectRequestTracingSamplingRule(
            double rate,
            global::Vercel.UpdateProjectRequestTracingSamplingRuleEnv? env,
            string? requestPath)
        {
            this.Rate = rate;
            this.Env = env;
            this.RequestPath = requestPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTracingSamplingRule" /> class.
        /// </summary>
        public UpdateProjectRequestTracingSamplingRule()
        {
        }
    }
}