
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Retention policies for deployments. These are enforced at the project level, but we also maintain an instance of this at the team level as a default policy that gets applied to new projects.
    /// </summary>
    public sealed partial class GetProjectsResponseVariant1ItemDeploymentExpiration
    {
        /// <summary>
        /// Number of days to keep non-production deployments (mostly preview deployments) before soft deletion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDays")]
        public double? ExpirationDays { get; set; }

        /// <summary>
        /// Number of days to keep production deployments before soft deletion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDaysProduction")]
        public double? ExpirationDaysProduction { get; set; }

        /// <summary>
        /// Number of days to keep canceled deployments before soft deletion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDaysCanceled")]
        public double? ExpirationDaysCanceled { get; set; }

        /// <summary>
        /// Number of days to keep errored deployments before soft deletion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDaysErrored")]
        public double? ExpirationDaysErrored { get; set; }

        /// <summary>
        /// Minimum number of production deployments to keep for this project, even if they are over the production expiration limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentsToKeep")]
        public double? DeploymentsToKeep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemDeploymentExpiration" /> class.
        /// </summary>
        /// <param name="expirationDays">
        /// Number of days to keep non-production deployments (mostly preview deployments) before soft deletion.
        /// </param>
        /// <param name="expirationDaysProduction">
        /// Number of days to keep production deployments before soft deletion.
        /// </param>
        /// <param name="expirationDaysCanceled">
        /// Number of days to keep canceled deployments before soft deletion.
        /// </param>
        /// <param name="expirationDaysErrored">
        /// Number of days to keep errored deployments before soft deletion.
        /// </param>
        /// <param name="deploymentsToKeep">
        /// Minimum number of production deployments to keep for this project, even if they are over the production expiration limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant1ItemDeploymentExpiration(
            double? expirationDays,
            double? expirationDaysProduction,
            double? expirationDaysCanceled,
            double? expirationDaysErrored,
            double? deploymentsToKeep)
        {
            this.ExpirationDays = expirationDays;
            this.ExpirationDaysProduction = expirationDaysProduction;
            this.ExpirationDaysCanceled = expirationDaysCanceled;
            this.ExpirationDaysErrored = expirationDaysErrored;
            this.DeploymentsToKeep = deploymentsToKeep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemDeploymentExpiration" /> class.
        /// </summary>
        public GetProjectsResponseVariant1ItemDeploymentExpiration()
        {
        }
    }
}