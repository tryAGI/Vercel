
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMicrofrontendsInGroupResponseProjectPassport
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetMicrofrontendsInGroupResponseProjectPassportDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetMicrofrontendsInGroupResponseProjectPassportDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectPassport" /> class.
        /// </summary>
        /// <param name="connectorId"></param>
        /// <param name="deploymentType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMicrofrontendsInGroupResponseProjectPassport(
            string connectorId,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectPassportDeploymentType deploymentType)
        {
            this.ConnectorId = connectorId ?? throw new global::System.ArgumentNullException(nameof(connectorId));
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectPassport" /> class.
        /// </summary>
        public GetMicrofrontendsInGroupResponseProjectPassport()
        {
        }

    }
}