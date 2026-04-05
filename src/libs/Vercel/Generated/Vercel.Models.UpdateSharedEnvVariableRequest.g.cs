
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSharedEnvVariableRequest
    {
        /// <summary>
        /// An object where each key is an environment variable ID (not the key name) and the value is the update to apply<br/>
        /// Example: {"env_2WjyKQmM8ZnGcJsPWMrHRHrE":{"key":"API_URL","value":"https://api.vercel.com","target":["production","preview"],"projectIdUpdates":{"link":["prj_2WjyKQmM8ZnGcJsPWMrHRHrE"]}}}
        /// </summary>
        /// <example>{"env_2WjyKQmM8ZnGcJsPWMrHRHrE":{"key":"API_URL","value":"https://api.vercel.com","target":["production","preview"],"projectIdUpdates":{"link":["prj_2WjyKQmM8ZnGcJsPWMrHRHrE"]}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateSharedEnvVariableRequestUpdates2> Updates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSharedEnvVariableRequest" /> class.
        /// </summary>
        /// <param name="updates">
        /// An object where each key is an environment variable ID (not the key name) and the value is the update to apply<br/>
        /// Example: {"env_2WjyKQmM8ZnGcJsPWMrHRHrE":{"key":"API_URL","value":"https://api.vercel.com","target":["production","preview"],"projectIdUpdates":{"link":["prj_2WjyKQmM8ZnGcJsPWMrHRHrE"]}}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSharedEnvVariableRequest(
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateSharedEnvVariableRequestUpdates2> updates)
        {
            this.Updates = updates ?? throw new global::System.ArgumentNullException(nameof(updates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSharedEnvVariableRequest" /> class.
        /// </summary>
        public UpdateSharedEnvVariableRequest()
        {
        }
    }
}