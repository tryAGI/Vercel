
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared82154186cc88506cTransform
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Args { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.IList<string>? Env { get; set; }

        /// <summary>
        /// Keep an earlier request.path value. Builders use this for fallback routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback")]
        public bool? Fallback { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared82154186cc88506cTransformOpJsonConverter))]
        public global::Vercel.AutoSDKShared82154186cc88506cTransformOp Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared82154186cc88506cTransformTypeJsonConverter))]
        public global::Vercel.AutoSDKShared82154186cc88506cTransformType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared82154186cc88506cTransform" /> class.
        /// </summary>
        /// <param name="args"></param>
        /// <param name="env"></param>
        /// <param name="fallback">
        /// Keep an earlier request.path value. Builders use this for fallback routes.
        /// </param>
        /// <param name="op"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared82154186cc88506cTransform(
            string args,
            global::System.Collections.Generic.IList<string>? env,
            bool? fallback,
            global::Vercel.AutoSDKShared82154186cc88506cTransformOp op,
            global::Vercel.AutoSDKShared82154186cc88506cTransformType type)
        {
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Env = env;
            this.Fallback = fallback;
            this.Op = op;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared82154186cc88506cTransform" /> class.
        /// </summary>
        public AutoSDKShared82154186cc88506cTransform()
        {
        }

    }
}