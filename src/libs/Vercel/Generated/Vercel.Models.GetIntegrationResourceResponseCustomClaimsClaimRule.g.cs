
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetIntegrationResourceResponseCustomClaimsClaimRule
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.OneOf<string, double?, bool?>?> Claims { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("when")]
        public global::Vercel.GetIntegrationResourceResponseCustomClaimsClaimRuleWhen? When { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourceResponseCustomClaimsClaimRule" /> class.
        /// </summary>
        /// <param name="claims"></param>
        /// <param name="when"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetIntegrationResourceResponseCustomClaimsClaimRule(
            global::System.Collections.Generic.Dictionary<string, global::Vercel.OneOf<string, double?, bool?>?> claims,
            global::Vercel.GetIntegrationResourceResponseCustomClaimsClaimRuleWhen? when)
        {
            this.Claims = claims ?? throw new global::System.ArgumentNullException(nameof(claims));
            this.When = when;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourceResponseCustomClaimsClaimRule" /> class.
        /// </summary>
        public GetIntegrationResourceResponseCustomClaimsClaimRule()
        {
        }

    }
}