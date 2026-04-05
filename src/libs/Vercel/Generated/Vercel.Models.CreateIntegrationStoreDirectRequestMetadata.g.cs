
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional key-value pairs for resource metadata<br/>
    /// Example: {"environment":"development","project":"my-app","tags":["database","postgres"]}
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}