
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede052f139ff613de3InternalRouteVariant2HaVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede052f139ff613de3InternalRouteVariant2HaVariant2TypeJsonConverter))]
        public global::Vercel.AutoSDKSharede052f139ff613de3InternalRouteVariant2HaVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharede052f139ff613de3InternalRouteVariant2HaVariant2Value Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede052f139ff613de3InternalRouteVariant2HaVariant2" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede052f139ff613de3InternalRouteVariant2HaVariant2(
            global::Vercel.AutoSDKSharede052f139ff613de3InternalRouteVariant2HaVariant2Value value,
            global::Vercel.AutoSDKSharede052f139ff613de3InternalRouteVariant2HaVariant2Type type)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede052f139ff613de3InternalRouteVariant2HaVariant2" /> class.
        /// </summary>
        public AutoSDKSharede052f139ff613de3InternalRouteVariant2HaVariant2()
        {
        }

    }
}