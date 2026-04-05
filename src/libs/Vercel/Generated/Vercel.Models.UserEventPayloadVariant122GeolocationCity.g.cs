
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant122GeolocationCity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant122GeolocationCityNames Names { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant122GeolocationCity" /> class.
        /// </summary>
        /// <param name="names"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant122GeolocationCity(
            global::Vercel.UserEventPayloadVariant122GeolocationCityNames names)
        {
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant122GeolocationCity" /> class.
        /// </summary>
        public UserEventPayloadVariant122GeolocationCity()
        {
        }
    }
}