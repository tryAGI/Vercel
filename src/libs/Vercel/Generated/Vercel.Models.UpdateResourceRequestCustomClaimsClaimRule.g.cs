
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateResourceRequestCustomClaimsClaimRule
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("when")]
        public global::Vercel.UpdateResourceRequestCustomClaimsClaimRuleWhen? When { get; set; }

        /// <summary>
        /// Claims to set (string, number, or boolean), shallow-merged over earlier rules and over the default claims. `null` removes a claim. Reserved claims cannot be set; `aud` and `sub` can be overridden with a string but not removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.OneOf<string, double?, bool?>?> Claims { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceRequestCustomClaimsClaimRule" /> class.
        /// </summary>
        /// <param name="claims">
        /// Claims to set (string, number, or boolean), shallow-merged over earlier rules and over the default claims. `null` removes a claim. Reserved claims cannot be set; `aud` and `sub` can be overridden with a string but not removed.
        /// </param>
        /// <param name="when"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateResourceRequestCustomClaimsClaimRule(
            global::System.Collections.Generic.Dictionary<string, global::Vercel.OneOf<string, double?, bool?>?> claims,
            global::Vercel.UpdateResourceRequestCustomClaimsClaimRuleWhen? when)
        {
            this.When = when;
            this.Claims = claims ?? throw new global::System.ArgumentNullException(nameof(claims));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceRequestCustomClaimsClaimRule" /> class.
        /// </summary>
        public UpdateResourceRequestCustomClaimsClaimRule()
        {
        }

    }
}