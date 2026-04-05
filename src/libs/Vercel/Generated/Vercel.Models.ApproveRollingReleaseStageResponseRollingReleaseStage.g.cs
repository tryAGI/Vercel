
#nullable enable

namespace Vercel
{
    /// <summary>
    /// All stages configured for this rolling release<br/>
    /// Example: [{"index":0,"isFinalStage":false,"targetPercentage":5,"requireApproval":true,"duration":null}, {"index":1,"isFinalStage":false,"targetPercentage":25,"requireApproval":true,"duration":null}, {"index":2,"isFinalStage":false,"targetPercentage":60,"requireApproval":true,"duration":null}, {"index":3,"isFinalStage":true,"targetPercentage":100,"requireApproval":false,"duration":null}]
    /// </summary>
    public sealed partial class ApproveRollingReleaseStageResponseRollingReleaseStage
    {
        /// <summary>
        /// The zero-based index of the stage<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Index { get; set; }

        /// <summary>
        /// Whether or not this stage is the final stage (targetPercentage === 100)<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFinalStage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFinalStage { get; set; }

        /// <summary>
        /// The percentage of traffic to serve to the canary deployment (0-100)<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetPercentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TargetPercentage { get; set; }

        /// <summary>
        /// Whether or not this stage requires manual approval to proceed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requireApproval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequireApproval { get; set; }

        /// <summary>
        /// Duration in seconds for automatic advancement, null for manual stages or the final stage<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
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
        /// Initializes a new instance of the <see cref="ApproveRollingReleaseStageResponseRollingReleaseStage" /> class.
        /// </summary>
        /// <param name="index">
        /// The zero-based index of the stage<br/>
        /// Example: 0
        /// </param>
        /// <param name="isFinalStage">
        /// Whether or not this stage is the final stage (targetPercentage === 100)<br/>
        /// Example: false
        /// </param>
        /// <param name="targetPercentage">
        /// The percentage of traffic to serve to the canary deployment (0-100)<br/>
        /// Example: 25
        /// </param>
        /// <param name="requireApproval">
        /// Whether or not this stage requires manual approval to proceed
        /// </param>
        /// <param name="duration">
        /// Duration in seconds for automatic advancement, null for manual stages or the final stage<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="linearShift">
        /// Whether to linearly shift traffic over the duration of this stage<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApproveRollingReleaseStageResponseRollingReleaseStage(
            double index,
            bool isFinalStage,
            double targetPercentage,
            bool requireApproval,
            double? duration,
            bool? linearShift)
        {
            this.Index = index;
            this.IsFinalStage = isFinalStage;
            this.TargetPercentage = targetPercentage;
            this.RequireApproval = requireApproval;
            this.Duration = duration;
            this.LinearShift = linearShift;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveRollingReleaseStageResponseRollingReleaseStage" /> class.
        /// </summary>
        public ApproveRollingReleaseStageResponseRollingReleaseStage()
        {
        }
    }
}