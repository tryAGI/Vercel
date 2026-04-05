
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Attribution information for the session or current page
    /// </summary>
    public sealed partial class CreateTeamRequestAttribution
    {
        /// <summary>
        /// Session referrer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionReferrer")]
        public string? SessionReferrer { get; set; }

        /// <summary>
        /// Session landing page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("landingPage")]
        public string? LandingPage { get; set; }

        /// <summary>
        /// Referrer to the signup page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageBeforeConversionPage")]
        public string? PageBeforeConversionPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utm")]
        public global::Vercel.CreateTeamRequestAttributionUtm? Utm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamRequestAttribution" /> class.
        /// </summary>
        /// <param name="sessionReferrer">
        /// Session referrer
        /// </param>
        /// <param name="landingPage">
        /// Session landing page
        /// </param>
        /// <param name="pageBeforeConversionPage">
        /// Referrer to the signup page
        /// </param>
        /// <param name="utm"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTeamRequestAttribution(
            string? sessionReferrer,
            string? landingPage,
            string? pageBeforeConversionPage,
            global::Vercel.CreateTeamRequestAttributionUtm? utm)
        {
            this.SessionReferrer = sessionReferrer;
            this.LandingPage = landingPage;
            this.PageBeforeConversionPage = pageBeforeConversionPage;
            this.Utm = utm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamRequestAttribution" /> class.
        /// </summary>
        public CreateTeamRequestAttribution()
        {
        }
    }
}