
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDomainConfigResponse
    {
        /// <summary>
        /// How we see the domain's configuration. - `CNAME`: Domain has a CNAME pointing to Vercel. - `A`: Domain's A record is resolving to Vercel. - `http`: Domain is resolving to Vercel but may be behind a Proxy. - `dns-01`: Domain is not resolving to Vercel but dns-01 challenge is enabled. - `null`: Domain is not resolving to Vercel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuredBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDomainConfigResponseConfiguredByJsonConverter))]
        public global::Vercel.GetDomainConfigResponseConfiguredBy? ConfiguredBy { get; set; }

        /// <summary>
        /// Which challenge types the domain can use for issuing certs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acceptedChallenges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetDomainConfigResponseAcceptedChallenge> AcceptedChallenges { get; set; }

        /// <summary>
        /// Recommended IPv4s for the domain. rank=1 is the preferred value(s) to use. Only using 1 ip value is acceptable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommendedIPv4")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetDomainConfigResponseRecommendedIPv4Item> RecommendedIPv4 { get; set; }

        /// <summary>
        /// Recommended CNAMEs for the domain. rank=1 is the preferred value to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommendedCNAME")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetDomainConfigResponseRecommendedCNAMEItem> RecommendedCNAME { get; set; }

        /// <summary>
        /// Whether or not the domain is configured AND we can automatically generate a TLS certificate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("misconfigured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Misconfigured { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainConfigResponse" /> class.
        /// </summary>
        /// <param name="acceptedChallenges">
        /// Which challenge types the domain can use for issuing certs.
        /// </param>
        /// <param name="recommendedIPv4">
        /// Recommended IPv4s for the domain. rank=1 is the preferred value(s) to use. Only using 1 ip value is acceptable.
        /// </param>
        /// <param name="recommendedCNAME">
        /// Recommended CNAMEs for the domain. rank=1 is the preferred value to use.
        /// </param>
        /// <param name="misconfigured">
        /// Whether or not the domain is configured AND we can automatically generate a TLS certificate.
        /// </param>
        /// <param name="configuredBy">
        /// How we see the domain's configuration. - `CNAME`: Domain has a CNAME pointing to Vercel. - `A`: Domain's A record is resolving to Vercel. - `http`: Domain is resolving to Vercel but may be behind a Proxy. - `dns-01`: Domain is not resolving to Vercel but dns-01 challenge is enabled. - `null`: Domain is not resolving to Vercel.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDomainConfigResponse(
            global::System.Collections.Generic.IList<global::Vercel.GetDomainConfigResponseAcceptedChallenge> acceptedChallenges,
            global::System.Collections.Generic.IList<global::Vercel.GetDomainConfigResponseRecommendedIPv4Item> recommendedIPv4,
            global::System.Collections.Generic.IList<global::Vercel.GetDomainConfigResponseRecommendedCNAMEItem> recommendedCNAME,
            bool misconfigured,
            global::Vercel.GetDomainConfigResponseConfiguredBy? configuredBy)
        {
            this.ConfiguredBy = configuredBy;
            this.AcceptedChallenges = acceptedChallenges ?? throw new global::System.ArgumentNullException(nameof(acceptedChallenges));
            this.RecommendedIPv4 = recommendedIPv4 ?? throw new global::System.ArgumentNullException(nameof(recommendedIPv4));
            this.RecommendedCNAME = recommendedCNAME ?? throw new global::System.ArgumentNullException(nameof(recommendedCNAME));
            this.Misconfigured = misconfigured;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainConfigResponse" /> class.
        /// </summary>
        public GetDomainConfigResponse()
        {
        }
    }
}