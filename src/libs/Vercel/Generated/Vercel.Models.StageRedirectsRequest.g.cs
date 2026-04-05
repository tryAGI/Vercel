
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StageRedirectsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirects")]
        public global::System.Collections.Generic.IList<global::Vercel.StageRedirectsRequestRedirect>? Redirects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StageRedirectsRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId"></param>
        /// <param name="overwrite"></param>
        /// <param name="name"></param>
        /// <param name="redirects">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StageRedirectsRequest(
            string projectId,
            string teamId,
            bool? overwrite,
            string? name,
            global::System.Collections.Generic.IList<global::Vercel.StageRedirectsRequestRedirect>? redirects)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Overwrite = overwrite;
            this.Name = name;
            this.Redirects = redirects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StageRedirectsRequest" /> class.
        /// </summary>
        public StageRedirectsRequest()
        {
        }
    }
}