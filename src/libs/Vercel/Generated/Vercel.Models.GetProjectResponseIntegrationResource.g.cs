
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The list of the installation resources connected to the project.
    /// </summary>
    public sealed partial class GetProjectResponseIntegrationResource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalResourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalResourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseIntegrationResource" /> class.
        /// </summary>
        /// <param name="externalResourceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseIntegrationResource(
            string externalResourceId)
        {
            this.ExternalResourceId = externalResourceId ?? throw new global::System.ArgumentNullException(nameof(externalResourceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseIntegrationResource" /> class.
        /// </summary>
        public GetProjectResponseIntegrationResource()
        {
        }
    }
}