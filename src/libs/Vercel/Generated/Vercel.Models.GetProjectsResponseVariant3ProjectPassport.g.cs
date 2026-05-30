
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectPassport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectPassportDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant3ProjectPassportDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectPassport" /> class.
        /// </summary>
        /// <param name="connectorId"></param>
        /// <param name="deploymentType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectPassport(
            string connectorId,
            global::Vercel.GetProjectsResponseVariant3ProjectPassportDeploymentType deploymentType)
        {
            this.ConnectorId = connectorId ?? throw new global::System.ArgumentNullException(nameof(connectorId));
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectPassport" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectPassport()
        {
        }

    }
}