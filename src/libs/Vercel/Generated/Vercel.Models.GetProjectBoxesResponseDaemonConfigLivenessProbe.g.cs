
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectBoxesResponseDaemonConfigLivenessProbe
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureThreshold")]
        public double? FailureThreshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpGet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGet HttpGet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initialDelaySeconds")]
        public double? InitialDelaySeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodSeconds")]
        public double? PeriodSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successThreshold")]
        public double? SuccessThreshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonConfigLivenessProbe" /> class.
        /// </summary>
        /// <param name="httpGet"></param>
        /// <param name="failureThreshold"></param>
        /// <param name="initialDelaySeconds"></param>
        /// <param name="periodSeconds"></param>
        /// <param name="successThreshold"></param>
        /// <param name="timeoutSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectBoxesResponseDaemonConfigLivenessProbe(
            global::Vercel.GetProjectBoxesResponseDaemonConfigLivenessProbeHttpGet httpGet,
            double? failureThreshold,
            double? initialDelaySeconds,
            double? periodSeconds,
            double? successThreshold,
            double? timeoutSeconds)
        {
            this.FailureThreshold = failureThreshold;
            this.HttpGet = httpGet ?? throw new global::System.ArgumentNullException(nameof(httpGet));
            this.InitialDelaySeconds = initialDelaySeconds;
            this.PeriodSeconds = periodSeconds;
            this.SuccessThreshold = successThreshold;
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonConfigLivenessProbe" /> class.
        /// </summary>
        public GetProjectBoxesResponseDaemonConfigLivenessProbe()
        {
        }

    }
}