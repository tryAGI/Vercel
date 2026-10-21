
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared19aed0f0e253807cInternalRouteVariant2HaVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared19aed0f0e253807cInternalRouteVariant2HaVariant1KeyJsonConverter))]
        public global::Vercel.AutoSDKShared19aed0f0e253807cInternalRouteVariant2HaVariant1Key Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared19aed0f0e253807cInternalRouteVariant2HaVariant1TypeJsonConverter))]
        public global::Vercel.AutoSDKShared19aed0f0e253807cInternalRouteVariant2HaVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared19aed0f0e253807cInternalRouteVariant2HaVariant1Value Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared19aed0f0e253807cInternalRouteVariant2HaVariant1" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared19aed0f0e253807cInternalRouteVariant2HaVariant1(
            global::Vercel.AutoSDKShared19aed0f0e253807cInternalRouteVariant2HaVariant1Value value,
            global::Vercel.AutoSDKShared19aed0f0e253807cInternalRouteVariant2HaVariant1Key key,
            global::Vercel.AutoSDKShared19aed0f0e253807cInternalRouteVariant2HaVariant1Type type)
        {
            this.Key = key;
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared19aed0f0e253807cInternalRouteVariant2HaVariant1" /> class.
        /// </summary>
        public AutoSDKShared19aed0f0e253807cInternalRouteVariant2HaVariant1()
        {
        }

    }
}