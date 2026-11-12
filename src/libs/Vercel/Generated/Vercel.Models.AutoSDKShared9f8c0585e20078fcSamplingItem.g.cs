
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9f8c0585e20078fcSamplingItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared9f8c0585e20078fcSamplingItemEnvJsonConverter))]
        public global::Vercel.AutoSDKShared9f8c0585e20078fcSamplingItemEnv? Env { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared9f8c0585e20078fcSamplingItemTypeJsonConverter))]
        public global::Vercel.AutoSDKShared9f8c0585e20078fcSamplingItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9f8c0585e20078fcSamplingItem" /> class.
        /// </summary>
        /// <param name="rate"></param>
        /// <param name="env"></param>
        /// <param name="requestPath"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9f8c0585e20078fcSamplingItem(
            double rate,
            global::Vercel.AutoSDKShared9f8c0585e20078fcSamplingItemEnv? env,
            string? requestPath,
            global::Vercel.AutoSDKShared9f8c0585e20078fcSamplingItemType type)
        {
            this.Env = env;
            this.Rate = rate;
            this.RequestPath = requestPath;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9f8c0585e20078fcSamplingItem" /> class.
        /// </summary>
        public AutoSDKShared9f8c0585e20078fcSamplingItem()
        {
        }

    }
}