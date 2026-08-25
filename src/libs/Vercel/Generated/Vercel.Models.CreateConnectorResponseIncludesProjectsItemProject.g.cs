
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Project metadata. `project.id` contains the same value as `projectId`.
    /// </summary>
    public sealed partial class CreateConnectorResponseIncludesProjectsItemProject
    {
        /// <summary>
        /// Same Vercel project ID as the connection's top-level `projectId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Current Vercel project name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Custom environments available on the project. This list can include environments where the connector is not enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironments")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateConnectorResponseIncludesProjectsItemProjectCustomEnvironment>? CustomEnvironments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseIncludesProjectsItemProject" /> class.
        /// </summary>
        /// <param name="id">
        /// Same Vercel project ID as the connection's top-level `projectId`.
        /// </param>
        /// <param name="name">
        /// Current Vercel project name.
        /// </param>
        /// <param name="customEnvironments">
        /// Custom environments available on the project. This list can include environments where the connector is not enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorResponseIncludesProjectsItemProject(
            string id,
            string name,
            global::System.Collections.Generic.IList<global::Vercel.CreateConnectorResponseIncludesProjectsItemProjectCustomEnvironment>? customEnvironments)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CustomEnvironments = customEnvironments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseIncludesProjectsItemProject" /> class.
        /// </summary>
        public CreateConnectorResponseIncludesProjectsItemProject()
        {
        }

    }
}