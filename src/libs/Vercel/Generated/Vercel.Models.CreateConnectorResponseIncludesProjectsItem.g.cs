
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorResponseIncludesProjectsItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::Vercel.CreateConnectorResponseIncludesProjectsItemProject? Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateConnectorResponseIncludesProjectsItemEnvironment> Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseIncludesProjectsItem" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="projectId"></param>
        /// <param name="environments"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="project"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorResponseIncludesProjectsItem(
            string clientId,
            string projectId,
            global::System.Collections.Generic.IList<global::Vercel.CreateConnectorResponseIncludesProjectsItemEnvironment> environments,
            double createdAt,
            double updatedAt,
            global::Vercel.CreateConnectorResponseIncludesProjectsItemProject? project)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Project = project;
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseIncludesProjectsItem" /> class.
        /// </summary>
        public CreateConnectorResponseIncludesProjectsItem()
        {
        }

    }
}