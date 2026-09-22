
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Retention policies for deployments. These are enforced at the project level, but we also maintain an instance of this at the team level as a default policy that gets applied to new projects.
    /// </summary>
    public sealed partial class AutoSDKSharedb950fa62fc8120e3DeploymentExpiration
    {
        /// <summary>
        /// Minimum number of production deployments to keep for this project, even if they are over the production expiration limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentsToKeep")]
        public double? DeploymentsToKeep { get; set; }

        /// <summary>
        /// Number of days to keep non-production deployments (mostly preview deployments) before soft deletion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDays")]
        public double? ExpirationDays { get; set; }

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
        /// Number of days to keep production deployments before soft deletion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDaysProduction")]
        public double? ExpirationDaysProduction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb950fa62fc8120e3DeploymentExpiration" /> class.
        /// </summary>
        /// <param name="deploymentsToKeep">
        /// Minimum number of production deployments to keep for this project, even if they are over the production expiration limit.
        /// </param>
        /// <param name="expirationDays">
        /// Number of days to keep non-production deployments (mostly preview deployments) before soft deletion.
        /// </param>
        /// <param name="expirationDaysCanceled">
        /// Number of days to keep canceled deployments before soft deletion.
        /// </param>
        /// <param name="expirationDaysErrored">
        /// Number of days to keep errored deployments before soft deletion.
        /// </param>
        /// <param name="expirationDaysProduction">
        /// Number of days to keep production deployments before soft deletion.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedb950fa62fc8120e3DeploymentExpiration(
            double? deploymentsToKeep,
            double? expirationDays,
            double? expirationDaysCanceled,
            double? expirationDaysErrored,
            double? expirationDaysProduction)
        {
            this.DeploymentsToKeep = deploymentsToKeep;
            this.ExpirationDays = expirationDays;
            this.ExpirationDaysCanceled = expirationDaysCanceled;
            this.ExpirationDaysErrored = expirationDaysErrored;
            this.ExpirationDaysProduction = expirationDaysProduction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb950fa62fc8120e3DeploymentExpiration" /> class.
        /// </summary>
        public AutoSDKSharedb950fa62fc8120e3DeploymentExpiration()
        {
        }

    }
}