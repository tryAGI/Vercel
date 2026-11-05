
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedab64e9622c80dc17Transform
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedab64e9622c80dc17TransformOpJsonConverter))]
        public global::Vercel.AutoSDKSharedab64e9622c80dc17TransformOp Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedab64e9622c80dc17TransformTarget Target { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedab64e9622c80dc17TransformTypeJsonConverter))]
        public global::Vercel.AutoSDKSharedab64e9622c80dc17TransformType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedab64e9622c80dc17Transform" /> class.
        /// </summary>
        /// <param name="args"></param>
        /// <param name="target"></param>
        /// <param name="op"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedab64e9622c80dc17Transform(
            string args,
            global::Vercel.AutoSDKSharedab64e9622c80dc17TransformTarget target,
            global::Vercel.AutoSDKSharedab64e9622c80dc17TransformOp op,
            global::Vercel.AutoSDKSharedab64e9622c80dc17TransformType type)
        {
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Op = op;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedab64e9622c80dc17Transform" /> class.
        /// </summary>
        public AutoSDKSharedab64e9622c80dc17Transform()
        {
        }

    }
}