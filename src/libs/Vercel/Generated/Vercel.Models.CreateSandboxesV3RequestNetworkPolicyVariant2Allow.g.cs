
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A rule applied to requests matching a domain in the network policy. Only one of `transform`, `forwardURL`, or `response` can be specified per rule.
    /// </summary>
    public sealed partial class CreateSandboxesV3RequestNetworkPolicyVariant2Allow
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}