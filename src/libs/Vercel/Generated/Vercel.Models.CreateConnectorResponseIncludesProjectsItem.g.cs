
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
        /// Project metadata. `project.id` contains the same value as `projectId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::Vercel.CreateConnectorResponseIncludesProjectsItemProject? Project { get; set; }

        /// <summary>
        /// Environments where this connector is enabled for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<string, global::Vercel.CreateConnectorResponseIncludesProjectsItemEnvironment?>> Environments { get; set; }

        /// <summary>
        /// Time when the project connection was created, in epoch milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Time when the project connection was last updated, in epoch milliseconds.
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
        /// <param name="environments">
        /// Environments where this connector is enabled for the project.
        /// </param>
        /// <param name="createdAt">
        /// Time when the project connection was created, in epoch milliseconds.
        /// </param>
        /// <param name="updatedAt">
        /// Time when the project connection was last updated, in epoch milliseconds.
        /// </param>
        /// <param name="project">
        /// Project metadata. `project.id` contains the same value as `projectId`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorResponseIncludesProjectsItem(
            string clientId,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<string, global::Vercel.CreateConnectorResponseIncludesProjectsItemEnvironment?>> environments,
            double createdAt,
            double updatedAt,
            global::Vercel.CreateConnectorResponseIncludesProjectsItemProject? project)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
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