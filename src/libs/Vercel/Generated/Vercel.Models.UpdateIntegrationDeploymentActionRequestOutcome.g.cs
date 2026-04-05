
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateIntegrationDeploymentActionRequestOutcome
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateIntegrationDeploymentActionRequestOutcomeSecret> Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIntegrationDeploymentActionRequestOutcome" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="secrets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateIntegrationDeploymentActionRequestOutcome(
            string kind,
            global::System.Collections.Generic.IList<global::Vercel.UpdateIntegrationDeploymentActionRequestOutcomeSecret> secrets)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIntegrationDeploymentActionRequestOutcome" /> class.
        /// </summary>
        public UpdateIntegrationDeploymentActionRequestOutcome()
        {
        }
    }
}