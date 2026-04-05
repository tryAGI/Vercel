
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectCrons
    {
        /// <summary>
        /// The time the feature was enabled for this project. Note: It enables automatically with the first Deployment that outputs cronjobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EnabledAt { get; set; }

        /// <summary>
        /// The time the feature was disabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledAt")]
        public double? DisabledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// The ID of the Deployment from which the definitions originated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definitions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectCronsDefinition> Definitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectCrons" /> class.
        /// </summary>
        /// <param name="enabledAt">
        /// The time the feature was enabled for this project. Note: It enables automatically with the first Deployment that outputs cronjobs.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="definitions"></param>
        /// <param name="disabledAt">
        /// The time the feature was disabled for this project.
        /// </param>
        /// <param name="deploymentId">
        /// The ID of the Deployment from which the definitions originated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectCrons(
            double enabledAt,
            double updatedAt,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectCronsDefinition> definitions,
            double? disabledAt,
            string? deploymentId)
        {
            this.EnabledAt = enabledAt;
            this.DisabledAt = disabledAt;
            this.UpdatedAt = updatedAt;
            this.DeploymentId = deploymentId;
            this.Definitions = definitions ?? throw new global::System.ArgumentNullException(nameof(definitions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectCrons" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectCrons()
        {
        }
    }
}