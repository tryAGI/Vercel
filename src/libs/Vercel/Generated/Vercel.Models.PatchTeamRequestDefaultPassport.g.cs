
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default Passport configuration for new projects.
    /// </summary>
    public sealed partial class PatchTeamRequestDefaultPassport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectorId { get; set; }

        /// <summary>
        /// Default Value: all
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchTeamRequestDefaultPassportDeploymentTypeJsonConverter))]
        public global::Vercel.PatchTeamRequestDefaultPassportDeploymentType? DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDefaultPassport" /> class.
        /// </summary>
        /// <param name="connectorId"></param>
        /// <param name="deploymentType">
        /// Default Value: all
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestDefaultPassport(
            string connectorId,
            global::Vercel.PatchTeamRequestDefaultPassportDeploymentType? deploymentType)
        {
            this.ConnectorId = connectorId ?? throw new global::System.ArgumentNullException(nameof(connectorId));
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDefaultPassport" /> class.
        /// </summary>
        public PatchTeamRequestDefaultPassport()
        {
        }

    }
}