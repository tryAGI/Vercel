
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Vercel project connected to the connector.
    /// </summary>
    public sealed partial class ConnectProjectConnectionProject
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
        public global::System.Collections.Generic.IList<global::Vercel.ConnectProjectConnectionProjectCustomEnvironment>? CustomEnvironments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectProjectConnectionProject" /> class.
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
        public ConnectProjectConnectionProject(
            string id,
            string name,
            global::System.Collections.Generic.IList<global::Vercel.ConnectProjectConnectionProjectCustomEnvironment>? customEnvironments)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CustomEnvironments = customEnvironments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectProjectConnectionProject" /> class.
        /// </summary>
        public ConnectProjectConnectionProject()
        {
        }

    }
}