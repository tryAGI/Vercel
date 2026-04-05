
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteSharedEnvVariableRequest
    {
        /// <summary>
        /// IDs of the Shared Environment Variables to delete<br/>
        /// Example: [env_abc123, env_abc124]
        /// </summary>
        /// <example>[env_abc123, env_abc124]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSharedEnvVariableRequest" /> class.
        /// </summary>
        /// <param name="ids">
        /// IDs of the Shared Environment Variables to delete<br/>
        /// Example: [env_abc123, env_abc124]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteSharedEnvVariableRequest(
            global::System.Collections.Generic.IList<string> ids)
        {
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSharedEnvVariableRequest" /> class.
        /// </summary>
        public DeleteSharedEnvVariableRequest()
        {
        }
    }
}