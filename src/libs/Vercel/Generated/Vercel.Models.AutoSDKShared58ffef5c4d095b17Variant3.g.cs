
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared58ffef5c4d095b17Variant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared58ffef5c4d095b17Variant3App App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared58ffef5c4d095b17Variant3TypeJsonConverter))]
        public global::Vercel.AutoSDKShared58ffef5c4d095b17Variant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared58ffef5c4d095b17Variant3" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared58ffef5c4d095b17Variant3(
            global::Vercel.AutoSDKShared58ffef5c4d095b17Variant3App app,
            global::Vercel.AutoSDKShared58ffef5c4d095b17Variant3Type type)
        {
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared58ffef5c4d095b17Variant3" /> class.
        /// </summary>
        public AutoSDKShared58ffef5c4d095b17Variant3()
        {
        }

    }
}