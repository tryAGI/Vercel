
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Additional environment variables to set for this command. These are merged with the sandbox environment.<br/>
    /// Default Value: {}<br/>
    /// Example: {"NODE_ENV":"production","DEBUG":"true"}
    /// </summary>
    public sealed partial class RunSessionCommandRequestEnv
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}