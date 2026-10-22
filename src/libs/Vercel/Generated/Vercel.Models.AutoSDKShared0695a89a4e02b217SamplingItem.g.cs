
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0695a89a4e02b217SamplingItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0695a89a4e02b217SamplingItemEnvJsonConverter))]
        public global::Vercel.AutoSDKShared0695a89a4e02b217SamplingItemEnv? Env { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0695a89a4e02b217SamplingItemTypeJsonConverter))]
        public global::Vercel.AutoSDKShared0695a89a4e02b217SamplingItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0695a89a4e02b217SamplingItem" /> class.
        /// </summary>
        /// <param name="rate"></param>
        /// <param name="env"></param>
        /// <param name="requestPath"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0695a89a4e02b217SamplingItem(
            double rate,
            global::Vercel.AutoSDKShared0695a89a4e02b217SamplingItemEnv? env,
            string? requestPath,
            global::Vercel.AutoSDKShared0695a89a4e02b217SamplingItemType type)
        {
            this.Env = env;
            this.Rate = rate;
            this.RequestPath = requestPath;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0695a89a4e02b217SamplingItem" /> class.
        /// </summary>
        public AutoSDKShared0695a89a4e02b217SamplingItem()
        {
        }

    }
}