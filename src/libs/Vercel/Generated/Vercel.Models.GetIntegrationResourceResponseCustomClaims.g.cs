
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The roles and claim rules Vercel resolves into the resource tokens it mints for this resource
    /// </summary>
    public sealed partial class GetIntegrationResourceResponseCustomClaims
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claimRules")]
        public global::System.Collections.Generic.IList<global::Vercel.GetIntegrationResourceResponseCustomClaimsClaimRule>? ClaimRules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRole")]
        public string? DefaultRole { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<string>? Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourceResponseCustomClaims" /> class.
        /// </summary>
        /// <param name="claimRules"></param>
        /// <param name="defaultRole"></param>
        /// <param name="roles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetIntegrationResourceResponseCustomClaims(
            global::System.Collections.Generic.IList<global::Vercel.GetIntegrationResourceResponseCustomClaimsClaimRule>? claimRules,
            string? defaultRole,
            global::System.Collections.Generic.IList<string>? roles)
        {
            this.ClaimRules = claimRules;
            this.DefaultRole = defaultRole;
            this.Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourceResponseCustomClaims" /> class.
        /// </summary>
        public GetIntegrationResourceResponseCustomClaims()
        {
        }

    }
}