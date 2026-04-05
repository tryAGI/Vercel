
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default environment variables for the sandbox. These are inherited by all commands unless overridden.<br/>
    /// Default Value: {}<br/>
    /// Example: {"NODE_ENV":"production","HELLO":"world"}
    /// </summary>
    public sealed partial class CreateSandboxRequestEnv
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}