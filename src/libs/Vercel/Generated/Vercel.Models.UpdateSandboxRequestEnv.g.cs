
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default environment variables for the sandbox. Set to empty object to clear.<br/>
    /// Example: {"NODE_ENV":"production","HELLO":"world"}
    /// </summary>
    public sealed partial class UpdateSandboxRequestEnv
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}