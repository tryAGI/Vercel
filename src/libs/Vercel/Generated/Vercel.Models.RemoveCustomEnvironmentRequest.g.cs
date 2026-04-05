
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveCustomEnvironmentRequest
    {
        /// <summary>
        /// Delete Environment Variables that are not assigned to any environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteUnassignedEnvironmentVariables")]
        public bool? DeleteUnassignedEnvironmentVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveCustomEnvironmentRequest" /> class.
        /// </summary>
        /// <param name="deleteUnassignedEnvironmentVariables">
        /// Delete Environment Variables that are not assigned to any environments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveCustomEnvironmentRequest(
            bool? deleteUnassignedEnvironmentVariables)
        {
            this.DeleteUnassignedEnvironmentVariables = deleteUnassignedEnvironmentVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveCustomEnvironmentRequest" /> class.
        /// </summary>
        public RemoveCustomEnvironmentRequest()
        {
        }
    }
}