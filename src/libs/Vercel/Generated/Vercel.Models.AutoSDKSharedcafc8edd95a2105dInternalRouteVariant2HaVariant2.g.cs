
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2HaVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2HaVariant2TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2HaVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2HaVariant2Value Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2HaVariant2" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2HaVariant2(
            global::Vercel.AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2HaVariant2Value value,
            global::Vercel.AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2HaVariant2Type type)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2HaVariant2" /> class.
        /// </summary>
        public AutoSDKSharedcafc8edd95a2105dInternalRouteVariant2HaVariant2()
        {
        }

    }
}