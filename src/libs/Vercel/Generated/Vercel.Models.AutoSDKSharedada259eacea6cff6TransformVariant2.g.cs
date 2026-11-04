
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedada259eacea6cff6TransformVariant2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedada259eacea6cff6TransformVariant2OpJsonConverter))]
        public global::Vercel.AutoSDKSharedada259eacea6cff6TransformVariant2Op Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedada259eacea6cff6TransformVariant2TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedada259eacea6cff6TransformVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedada259eacea6cff6TransformVariant2" /> class.
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
        public AutoSDKSharedada259eacea6cff6TransformVariant2(
            string args,
            global::System.Collections.Generic.IList<string>? env,
            bool? fallback,
            global::Vercel.AutoSDKSharedada259eacea6cff6TransformVariant2Op op,
            global::Vercel.AutoSDKSharedada259eacea6cff6TransformVariant2Type type)
        {
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Env = env;
            this.Fallback = fallback;
            this.Op = op;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedada259eacea6cff6TransformVariant2" /> class.
        /// </summary>
        public AutoSDKSharedada259eacea6cff6TransformVariant2()
        {
        }

    }
}