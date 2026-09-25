
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Claims to set (string, number, or boolean), shallow-merged over earlier rules and over the default claims. `null` removes a claim. Reserved claims cannot be set; `aud` and `sub` can be overridden with a string but not removed.
    /// </summary>
    public sealed partial class ImportResourceRequestCustomClaimsClaimRuleClaims
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}