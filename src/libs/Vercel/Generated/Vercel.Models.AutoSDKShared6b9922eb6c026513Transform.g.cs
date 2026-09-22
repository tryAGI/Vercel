
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared6b9922eb6c026513Transform
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
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6b9922eb6c026513TransformOpJsonConverter))]
        public global::Vercel.AutoSDKShared6b9922eb6c026513TransformOp Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared6b9922eb6c026513TransformTarget Target { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6b9922eb6c026513TransformTypeJsonConverter))]
        public global::Vercel.AutoSDKShared6b9922eb6c026513TransformType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6b9922eb6c026513Transform" /> class.
        /// </summary>
        /// <param name="args"></param>
        /// <param name="target"></param>
        /// <param name="op"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared6b9922eb6c026513Transform(
            string args,
            global::Vercel.AutoSDKShared6b9922eb6c026513TransformTarget target,
            global::Vercel.AutoSDKShared6b9922eb6c026513TransformOp op,
            global::Vercel.AutoSDKShared6b9922eb6c026513TransformType type)
        {
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Op = op;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6b9922eb6c026513Transform" /> class.
        /// </summary>
        public AutoSDKShared6b9922eb6c026513Transform()
        {
        }

    }
}