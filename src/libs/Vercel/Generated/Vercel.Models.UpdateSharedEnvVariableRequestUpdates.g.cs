
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An object where each key is an environment variable ID (not the key name) and the value is the update to apply<br/>
    /// Example: {"env_2WjyKQmM8ZnGcJsPWMrHRHrE":{"key":"API_URL","value":"https://api.vercel.com","target":["production","preview"],"projectIdUpdates":{"link":["prj_2WjyKQmM8ZnGcJsPWMrHRHrE"]}}}
    /// </summary>
    public sealed partial class UpdateSharedEnvVariableRequestUpdates
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}