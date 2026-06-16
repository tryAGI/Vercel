
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
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetMicrofrontendsInGroupResponseProjectPassportDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetMicrofrontendsInGroupResponseProjectPassportDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectorId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectPassport" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
        /// <param name="connectorId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMicrofrontendsInGroupResponseProjectPassport(
            global::Vercel.GetMicrofrontendsInGroupResponseProjectPassportDeploymentType deploymentType,
            string connectorId)
        {
            this.DeploymentType = deploymentType;
            this.ConnectorId = connectorId ?? throw new global::System.ArgumentNullException(nameof(connectorId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectPassport" /> class.
        /// </summary>
        public GetMicrofrontendsInGroupResponseProjectPassport()
        {
        }

    }
}