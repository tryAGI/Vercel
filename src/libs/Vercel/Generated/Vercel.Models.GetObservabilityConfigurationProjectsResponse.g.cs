
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetObservabilityConfigurationProjectsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledProjects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetObservabilityConfigurationProjectsResponseDisabledProject> DisabledProjects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObservabilityConfigurationProjectsResponse" /> class.
        /// </summary>
        /// <param name="disabledProjects"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetObservabilityConfigurationProjectsResponse(
            global::System.Collections.Generic.IList<global::Vercel.GetObservabilityConfigurationProjectsResponseDisabledProject> disabledProjects)
        {
            this.DisabledProjects = disabledProjects ?? throw new global::System.ArgumentNullException(nameof(disabledProjects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObservabilityConfigurationProjectsResponse" /> class.
        /// </summary>
        public GetObservabilityConfigurationProjectsResponse()
        {
        }
    }
}