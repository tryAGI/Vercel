
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTeamRequestAttributionUtm
    {
        /// <summary>
        /// UTM source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utmSource")]
        public string? UtmSource { get; set; }

        /// <summary>
        /// UTM medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utmMedium")]
        public string? UtmMedium { get; set; }

        /// <summary>
        /// UTM campaign
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utmCampaign")]
        public string? UtmCampaign { get; set; }

        /// <summary>
        /// UTM term
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utmTerm")]
        public string? UtmTerm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamRequestAttributionUtm" /> class.
        /// </summary>
        /// <param name="utmSource">
        /// UTM source
        /// </param>
        /// <param name="utmMedium">
        /// UTM medium
        /// </param>
        /// <param name="utmCampaign">
        /// UTM campaign
        /// </param>
        /// <param name="utmTerm">
        /// UTM term
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTeamRequestAttributionUtm(
            string? utmSource,
            string? utmMedium,
            string? utmCampaign,
            string? utmTerm)
        {
            this.UtmSource = utmSource;
            this.UtmMedium = utmMedium;
            this.UtmCampaign = utmCampaign;
            this.UtmTerm = utmTerm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamRequestAttributionUtm" /> class.
        /// </summary>
        public CreateTeamRequestAttributionUtm()
        {
        }
    }
}