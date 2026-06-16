
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadProjectAvatarResponseTracingSamplingRule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UploadProjectAvatarResponseTracingSamplingRuleEnvJsonConverter))]
        public global::Vercel.UploadProjectAvatarResponseTracingSamplingRuleEnv? Env { get; set; }

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
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseTracingSamplingRule" /> class.
        /// </summary>
        /// <param name="rate"></param>
        /// <param name="env"></param>
        /// <param name="requestPath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadProjectAvatarResponseTracingSamplingRule(
            double rate,
            global::Vercel.UploadProjectAvatarResponseTracingSamplingRuleEnv? env,
            string? requestPath)
        {
            this.Rate = rate;
            this.Env = env;
            this.RequestPath = requestPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseTracingSamplingRule" /> class.
        /// </summary>
        public UploadProjectAvatarResponseTracingSamplingRule()
        {
        }

    }
}