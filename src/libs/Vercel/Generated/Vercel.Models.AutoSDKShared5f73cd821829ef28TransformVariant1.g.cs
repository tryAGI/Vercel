
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared5f73cd821829ef28TransformVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? Args { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.IList<string>? Env { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared5f73cd821829ef28TransformVariant1OpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared5f73cd821829ef28TransformVariant1Op Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared5f73cd821829ef28TransformVariant1Target Target { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared5f73cd821829ef28TransformVariant1TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared5f73cd821829ef28TransformVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared5f73cd821829ef28TransformVariant1" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="target"></param>
        /// <param name="type"></param>
        /// <param name="args"></param>
        /// <param name="env"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared5f73cd821829ef28TransformVariant1(
            global::Vercel.AutoSDKShared5f73cd821829ef28TransformVariant1Op op,
            global::Vercel.AutoSDKShared5f73cd821829ef28TransformVariant1Target target,
            global::Vercel.AutoSDKShared5f73cd821829ef28TransformVariant1Type type,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? args,
            global::System.Collections.Generic.IList<string>? env)
        {
            this.Args = args;
            this.Env = env;
            this.Op = op;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared5f73cd821829ef28TransformVariant1" /> class.
        /// </summary>
        public AutoSDKShared5f73cd821829ef28TransformVariant1()
        {
        }

    }
}