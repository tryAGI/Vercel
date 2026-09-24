
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetIntegrationResourceResponseCustomClaimsClaimRuleWhen
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public global::System.Collections.Generic.IList<string>? Environment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public global::System.Collections.Generic.IList<string>? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourceResponseCustomClaimsClaimRuleWhen" /> class.
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetIntegrationResourceResponseCustomClaimsClaimRuleWhen(
            global::System.Collections.Generic.IList<string>? environment,
            global::System.Collections.Generic.IList<string>? role)
        {
            this.Environment = environment;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourceResponseCustomClaimsClaimRuleWhen" /> class.
        /// </summary>
        public GetIntegrationResourceResponseCustomClaimsClaimRuleWhen()
        {
        }

    }
}