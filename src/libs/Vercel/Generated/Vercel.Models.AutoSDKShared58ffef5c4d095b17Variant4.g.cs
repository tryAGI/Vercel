
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared58ffef5c4d095b17Variant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared58ffef5c4d095b17Variant4Integration Integration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared58ffef5c4d095b17Variant4TypeJsonConverter))]
        public global::Vercel.AutoSDKShared58ffef5c4d095b17Variant4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared58ffef5c4d095b17Variant4" /> class.
        /// </summary>
        /// <param name="integration"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared58ffef5c4d095b17Variant4(
            global::Vercel.AutoSDKShared58ffef5c4d095b17Variant4Integration integration,
            global::Vercel.AutoSDKShared58ffef5c4d095b17Variant4Type type)
        {
            this.Integration = integration ?? throw new global::System.ArgumentNullException(nameof(integration));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared58ffef5c4d095b17Variant4" /> class.
        /// </summary>
        public AutoSDKShared58ffef5c4d095b17Variant4()
        {
        }

    }
}