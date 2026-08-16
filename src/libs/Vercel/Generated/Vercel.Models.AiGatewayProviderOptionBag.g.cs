
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Arbitrary per-provider AI SDK options, keyed by gateway provider slug.
    /// </summary>
    public sealed partial class AiGatewayProviderOptionBag
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}