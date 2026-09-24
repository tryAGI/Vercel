
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Custom claims embedded in the resource tokens Vercel mints for this resource.
    /// </summary>
    public sealed partial class ImportResourceRequestCustomClaims
    {
        /// <summary>
        /// Roles a deployment may request when minting a token. The selected role becomes the `sub` claim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<string>? Roles { get; set; }

        /// <summary>
        /// Role used when the deployment does not request one. Required when `roles` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRole")]
        public string? DefaultRole { get; set; }

        /// <summary>
        /// Ordered rules resolved at mint time. Later rules win and shallow-merge over earlier ones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claimRules")]
        public global::System.Collections.Generic.IList<global::Vercel.ImportResourceRequestCustomClaimsClaimRule>? ClaimRules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportResourceRequestCustomClaims" /> class.
        /// </summary>
        /// <param name="roles">
        /// Roles a deployment may request when minting a token. The selected role becomes the `sub` claim.
        /// </param>
        /// <param name="defaultRole">
        /// Role used when the deployment does not request one. Required when `roles` is set.
        /// </param>
        /// <param name="claimRules">
        /// Ordered rules resolved at mint time. Later rules win and shallow-merge over earlier ones.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportResourceRequestCustomClaims(
            global::System.Collections.Generic.IList<string>? roles,
            string? defaultRole,
            global::System.Collections.Generic.IList<global::Vercel.ImportResourceRequestCustomClaimsClaimRule>? claimRules)
        {
            this.Roles = roles;
            this.DefaultRole = defaultRole;
            this.ClaimRules = claimRules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportResourceRequestCustomClaims" /> class.
        /// </summary>
        public ImportResourceRequestCustomClaims()
        {
        }

    }
}