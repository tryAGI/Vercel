
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda3e211e8bee7aaa5SamplingItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda3e211e8bee7aaa5SamplingItemEnvJsonConverter))]
        public global::Vercel.AutoSDKShareda3e211e8bee7aaa5SamplingItemEnv? Env { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda3e211e8bee7aaa5SamplingItemTypeJsonConverter))]
        public global::Vercel.AutoSDKShareda3e211e8bee7aaa5SamplingItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda3e211e8bee7aaa5SamplingItem" /> class.
        /// </summary>
        /// <param name="rate"></param>
        /// <param name="env"></param>
        /// <param name="requestPath"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda3e211e8bee7aaa5SamplingItem(
            double rate,
            global::Vercel.AutoSDKShareda3e211e8bee7aaa5SamplingItemEnv? env,
            string? requestPath,
            global::Vercel.AutoSDKShareda3e211e8bee7aaa5SamplingItemType type)
        {
            this.Env = env;
            this.Rate = rate;
            this.RequestPath = requestPath;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda3e211e8bee7aaa5SamplingItem" /> class.
        /// </summary>
        public AutoSDKShareda3e211e8bee7aaa5SamplingItem()
        {
        }

    }
}