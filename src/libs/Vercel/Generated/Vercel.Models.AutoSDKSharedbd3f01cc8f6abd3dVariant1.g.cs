
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedbd3f01cc8f6abd3dVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Created { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant1Payload Payload { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedbd3f01cc8f6abd3dVariant1TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbd3f01cc8f6abd3dVariant1" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="payload"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedbd3f01cc8f6abd3dVariant1(
            double created,
            global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant1Payload payload,
            global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant1Type type)
        {
            this.Created = created;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbd3f01cc8f6abd3dVariant1" /> class.
        /// </summary>
        public AutoSDKSharedbd3f01cc8f6abd3dVariant1()
        {
        }

    }
}