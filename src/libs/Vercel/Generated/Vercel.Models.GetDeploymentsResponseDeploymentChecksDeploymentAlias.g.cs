
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Detailed information about v2 deployment checks. Includes information about blocked workflows in the deployment lifecycle.
    /// </summary>
    public sealed partial class GetDeploymentsResponseDeploymentChecksDeploymentAlias
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public double? CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentsResponseDeploymentChecksDeploymentAliasStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentsResponseDeploymentChecksDeploymentAliasState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeploymentChecksDeploymentAlias" /> class.
        /// </summary>
        /// <param name="startedAt"></param>
        /// <param name="state"></param>
        /// <param name="completedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentsResponseDeploymentChecksDeploymentAlias(
            double startedAt,
            global::Vercel.GetDeploymentsResponseDeploymentChecksDeploymentAliasState state,
            double? completedAt)
        {
            this.CompletedAt = completedAt;
            this.StartedAt = startedAt;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeploymentChecksDeploymentAlias" /> class.
        /// </summary>
        public GetDeploymentsResponseDeploymentChecksDeploymentAlias()
        {
        }

    }
}