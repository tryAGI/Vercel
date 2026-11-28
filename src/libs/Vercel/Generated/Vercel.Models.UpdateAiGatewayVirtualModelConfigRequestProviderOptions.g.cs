
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Provider-specific options, keyed by provider slug. The slug of one of your team's private providers is also valid. `null` removes the stored value.
    /// </summary>
    public sealed partial class UpdateAiGatewayVirtualModelConfigRequestProviderOptions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}