
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetIntegrationResourcesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetIntegrationResourcesResponseResource> Resources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourcesResponse" /> class.
        /// </summary>
        /// <param name="resources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetIntegrationResourcesResponse(
            global::System.Collections.Generic.IList<global::Vercel.GetIntegrationResourcesResponseResource> resources)
        {
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourcesResponse" /> class.
        /// </summary>
        public GetIntegrationResourcesResponse()
        {
        }
    }
}