
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant225Geolocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public global::Vercel.UserEventPayloadVariant225GeolocationCity? City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant225GeolocationCountry Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("most_specific_subdivision")]
        public global::Vercel.UserEventPayloadVariant225GeolocationMostSpecificSubdivision? MostSpecificSubdivision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regionName")]
        public string? RegionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant225Geolocation" /> class.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="mostSpecificSubdivision"></param>
        /// <param name="regionName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant225Geolocation(
            global::Vercel.UserEventPayloadVariant225GeolocationCountry country,
            global::Vercel.UserEventPayloadVariant225GeolocationCity? city,
            global::Vercel.UserEventPayloadVariant225GeolocationMostSpecificSubdivision? mostSpecificSubdivision,
            string? regionName)
        {
            this.City = city;
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
            this.MostSpecificSubdivision = mostSpecificSubdivision;
            this.RegionName = regionName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant225Geolocation" /> class.
        /// </summary>
        public UserEventPayloadVariant225Geolocation()
        {
        }
    }
}