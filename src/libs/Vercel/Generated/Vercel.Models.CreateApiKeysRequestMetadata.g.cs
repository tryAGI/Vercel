
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional generic metadata for the API key. The accepted shape depends on the key's `purpose` and is validated on creation; for `ai-gateway` keys this accepts `environment`.
    /// </summary>
    public sealed partial class CreateApiKeysRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}