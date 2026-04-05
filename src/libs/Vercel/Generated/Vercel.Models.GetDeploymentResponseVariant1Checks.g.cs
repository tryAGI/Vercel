
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1Checks
    {
        /// <summary>
        /// Condensed check data. Retrieve individual check and check run data using api-checks v2 routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment-alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant1ChecksDeploymentAlias DeploymentAlias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1Checks" /> class.
        /// </summary>
        /// <param name="deploymentAlias">
        /// Condensed check data. Retrieve individual check and check run data using api-checks v2 routes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1Checks(
            global::Vercel.GetDeploymentResponseVariant1ChecksDeploymentAlias deploymentAlias)
        {
            this.DeploymentAlias = deploymentAlias ?? throw new global::System.ArgumentNullException(nameof(deploymentAlias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1Checks" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1Checks()
        {
        }
    }
}