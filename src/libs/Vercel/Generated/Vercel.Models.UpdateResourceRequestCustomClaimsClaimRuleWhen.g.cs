
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateResourceRequestCustomClaimsClaimRuleWhen
    {
        /// <summary>
        /// Applies only when the token is minted for one of these roles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public global::System.Collections.Generic.IList<string>? Role { get; set; }

        /// <summary>
        /// Applies only when the token is minted for one of these environments: `production`, `preview`, `development`, or a custom environment slug. A custom environment also matches `preview`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public global::System.Collections.Generic.IList<string>? Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceRequestCustomClaimsClaimRuleWhen" /> class.
        /// </summary>
        /// <param name="role">
        /// Applies only when the token is minted for one of these roles.
        /// </param>
        /// <param name="environment">
        /// Applies only when the token is minted for one of these environments: `production`, `preview`, `development`, or a custom environment slug. A custom environment also matches `preview`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateResourceRequestCustomClaimsClaimRuleWhen(
            global::System.Collections.Generic.IList<string>? role,
            global::System.Collections.Generic.IList<string>? environment)
        {
            this.Role = role;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceRequestCustomClaimsClaimRuleWhen" /> class.
        /// </summary>
        public UpdateResourceRequestCustomClaimsClaimRuleWhen()
        {
        }

    }
}