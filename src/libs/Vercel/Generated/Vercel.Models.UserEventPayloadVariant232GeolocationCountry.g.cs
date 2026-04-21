
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant232GeolocationCountry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant232GeolocationCountryNames Names { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant232GeolocationCountry" /> class.
        /// </summary>
        /// <param name="names"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant232GeolocationCountry(
            global::Vercel.UserEventPayloadVariant232GeolocationCountryNames names)
        {
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant232GeolocationCountry" /> class.
        /// </summary>
        public UserEventPayloadVariant232GeolocationCountry()
        {
        }
    }
}