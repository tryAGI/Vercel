
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Claim rules applied after the resource’s own rules when this deployment mints a resource token. Reserved claims cannot be set.
    /// </summary>
    public sealed partial class UpdateIntegrationDeploymentActionRequestOutcomeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// Ordered rules resolved at mint time. Later rules win and shallow-merge over earlier ones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claimRules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateIntegrationDeploymentActionRequestOutcomeVariant2ClaimRule> ClaimRules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIntegrationDeploymentActionRequestOutcomeVariant2" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="claimRules">
        /// Ordered rules resolved at mint time. Later rules win and shallow-merge over earlier ones.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateIntegrationDeploymentActionRequestOutcomeVariant2(
            string kind,
            global::System.Collections.Generic.IList<global::Vercel.UpdateIntegrationDeploymentActionRequestOutcomeVariant2ClaimRule> claimRules)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.ClaimRules = claimRules ?? throw new global::System.ArgumentNullException(nameof(claimRules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIntegrationDeploymentActionRequestOutcomeVariant2" /> class.
        /// </summary>
        public UpdateIntegrationDeploymentActionRequestOutcomeVariant2()
        {
        }

    }
}