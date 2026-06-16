
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default Passport configuration for new projects in this team.
    /// </summary>
    public sealed partial class TeamDefaultPassport
    {
        /// <summary>
        /// Default Passport configuration for new projects in this team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectorId { get; set; }

        /// <summary>
        /// Default Passport configuration for new projects in this team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TeamDefaultPassportDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.TeamDefaultPassportDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDefaultPassport" /> class.
        /// </summary>
        /// <param name="connectorId">
        /// Default Passport configuration for new projects in this team.
        /// </param>
        /// <param name="deploymentType">
        /// Default Passport configuration for new projects in this team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamDefaultPassport(
            string connectorId,
            global::Vercel.TeamDefaultPassportDeploymentType deploymentType)
        {
            this.ConnectorId = connectorId ?? throw new global::System.ArgumentNullException(nameof(connectorId));
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDefaultPassport" /> class.
        /// </summary>
        public TeamDefaultPassport()
        {
        }

    }
}