
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generic metadata attached to the API key.<br/>
    /// The accepted shape depends on the key's `purpose` and is validated when the key is created. For `ai-gateway` keys this carries `environment` and `spendAttribution`.
    /// </summary>
    public sealed partial class APIKeyMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}