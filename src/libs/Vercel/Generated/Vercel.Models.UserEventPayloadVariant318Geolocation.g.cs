
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant318Geolocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public global::Vercel.UserEventPayloadVariant318GeolocationCity? City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant318GeolocationCountry Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("most_specific_subdivision")]
        public global::Vercel.UserEventPayloadVariant318GeolocationMostSpecificSubdivision? MostSpecificSubdivision { get; set; }

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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant318Geolocation" /> class.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="mostSpecificSubdivision"></param>
        /// <param name="regionName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant318Geolocation(
            global::Vercel.UserEventPayloadVariant318GeolocationCountry country,
            global::Vercel.UserEventPayloadVariant318GeolocationCity? city,
            global::Vercel.UserEventPayloadVariant318GeolocationMostSpecificSubdivision? mostSpecificSubdivision,
            string? regionName)
        {
            this.City = city;
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
            this.MostSpecificSubdivision = mostSpecificSubdivision;
            this.RegionName = regionName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant318Geolocation" /> class.
        /// </summary>
        public UserEventPayloadVariant318Geolocation()
        {
        }
    }
}