
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default deployment expiration settings for this team
    /// </summary>
    public sealed partial class TeamDefaultExpirationSettings
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
        /// Initializes a new instance of the <see cref="TeamDefaultExpirationSettings" /> class.
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
        public TeamDefaultExpirationSettings(
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
        /// Initializes a new instance of the <see cref="TeamDefaultExpirationSettings" /> class.
        /// </summary>
        public TeamDefaultExpirationSettings()
        {
        }
    }
}