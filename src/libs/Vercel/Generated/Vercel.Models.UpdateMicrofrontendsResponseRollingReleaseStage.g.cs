
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An array of all the stages required during a deployment release. Each stage defines a target percentage and advancement rules. The final stage must always have targetPercentage: 100.
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseRollingReleaseStage
    {
        /// <summary>
        /// The percentage of traffic to serve to the canary deployment (0-100)<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetPercentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TargetPercentage { get; set; }

        /// <summary>
        /// Whether or not this stage requires manual approval to proceed<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requireApproval")]
        public bool? RequireApproval { get; set; }

        /// <summary>
        /// Duration in minutes for automatic advancement to the next stage<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Whether to linearly shift traffic over the duration of this stage<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("linearShift")]
        public bool? LinearShift { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseRollingReleaseStage" /> class.
        /// </summary>
        /// <param name="targetPercentage">
        /// The percentage of traffic to serve to the canary deployment (0-100)<br/>
        /// Example: 25
        /// </param>
        /// <param name="requireApproval">
        /// Whether or not this stage requires manual approval to proceed<br/>
        /// Example: false
        /// </param>
        /// <param name="duration">
        /// Duration in minutes for automatic advancement to the next stage<br/>
        /// Example: 600
        /// </param>
        /// <param name="linearShift">
        /// Whether to linearly shift traffic over the duration of this stage<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsResponseRollingReleaseStage(
            double targetPercentage,
            bool? requireApproval,
            double? duration,
            bool? linearShift)
        {
            this.TargetPercentage = targetPercentage;
            this.RequireApproval = requireApproval;
            this.Duration = duration;
            this.LinearShift = linearShift;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseRollingReleaseStage" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseRollingReleaseStage()
        {
        }
    }
}