
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Rolling release information including configuration and document details, or null if no rolling release exists
    /// </summary>
    public sealed partial class ApproveRollingReleaseStageResponseRollingRelease
    {
        /// <summary>
        /// The current state of the rolling release<br/>
        /// Example: ACTIVE
        /// </summary>
        /// <example>ACTIVE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseState State { get; set; }

        /// <summary>
        /// When set to `PAUSED`, the rollout is frozen at the current percentage until continued.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("substate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseSubstateJsonConverter))]
        public global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseSubstate? Substate { get; set; }

        /// <summary>
        /// The current deployment receiving production traffic<br/>
        /// Example: {"id":"dpl_abc123","name":"my-shop@main","url":"my-shop.vercel.app","target":"production","source":"git","createdAt":1716206500000,"readyState":"READY","readyStateAt":1716206800000}
        /// </summary>
        /// <example>{"id":"dpl_abc123","name":"my-shop@main","url":"my-shop.vercel.app","target":"production","source":"git","createdAt":1716206500000,"readyState":"READY","readyStateAt":1716206800000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentDeployment")]
        public global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeployment? CurrentDeployment { get; set; }

        /// <summary>
        /// The canary deployment being rolled out<br/>
        /// Example: {"id":"dpl_def456","name":"my-shop@9c7e2f4","url":"9c7e2f4-my-shop.vercel.app","target":"production","source":"git","createdAt":1716210100000,"readyState":"READY","readyStateAt":1716210400000}
        /// </summary>
        /// <example>{"id":"dpl_def456","name":"my-shop@9c7e2f4","url":"9c7e2f4-my-shop.vercel.app","target":"production","source":"git","createdAt":1716210100000,"readyState":"READY","readyStateAt":1716210400000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("canaryDeployment")]
        public global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeployment? CanaryDeployment { get; set; }

        /// <summary>
        /// The ID of a deployment queued for the next rolling release<br/>
        /// Example: dpl_ghi789
        /// </summary>
        /// <example>dpl_ghi789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("queuedDeploymentId")]
        public string? QueuedDeploymentId { get; set; }

        /// <summary>
        /// The advancement type of the rolling release<br/>
        /// Example: manual-approval
        /// </summary>
        /// <example>manual-approval</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("advancementType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ApproveRollingReleaseStageResponseRollingReleaseAdvancementTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseAdvancementType AdvancementType { get; set; }

        /// <summary>
        /// All stages configured for this rolling release<br/>
        /// Example: [{"index":0,"isFinalStage":false,"targetPercentage":5,"requireApproval":true,"duration":null}, {"index":1,"isFinalStage":false,"targetPercentage":25,"requireApproval":true,"duration":null}, {"index":2,"isFinalStage":false,"targetPercentage":60,"requireApproval":true,"duration":null}, {"index":3,"isFinalStage":true,"targetPercentage":100,"requireApproval":false,"duration":null}]
        /// </summary>
        /// <example>[{"index":0,"isFinalStage":false,"targetPercentage":5,"requireApproval":true,"duration":null}, {"index":1,"isFinalStage":false,"targetPercentage":25,"requireApproval":true,"duration":null}, {"index":2,"isFinalStage":false,"targetPercentage":60,"requireApproval":true,"duration":null}, {"index":3,"isFinalStage":true,"targetPercentage":100,"requireApproval":false,"duration":null}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseStage> Stages { get; set; }

        /// <summary>
        /// The currently active stage, null if the rollout is aborted<br/>
        /// Example: {"index":1,"isFinalStage":false,"targetPercentage":25,"requireApproval":true,"duration":null}
        /// </summary>
        /// <example>{"index":1,"isFinalStage":false,"targetPercentage":25,"requireApproval":true,"duration":null}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeStage")]
        public global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseActiveStage? ActiveStage { get; set; }

        /// <summary>
        /// The next stage to be activated, null if not in ACTIVE state<br/>
        /// Example: {"index":2,"isFinalStage":false,"targetPercentage":60,"requireApproval":true,"duration":null}
        /// </summary>
        /// <example>{"index":2,"isFinalStage":false,"targetPercentage":60,"requireApproval":true,"duration":null}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextStage")]
        public global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseNextStage? NextStage { get; set; }

        /// <summary>
        /// Unix timestamp in milliseconds when the rolling release started<br/>
        /// Example: 1716210500000L
        /// </summary>
        /// <example>1716210500000L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartedAt { get; set; }

        /// <summary>
        /// Unix timestamp in milliseconds when the rolling release was last updated<br/>
        /// Example: 1716210600000L
        /// </summary>
        /// <example>1716210600000L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveRollingReleaseStageResponseRollingRelease" /> class.
        /// </summary>
        /// <param name="state">
        /// The current state of the rolling release<br/>
        /// Example: ACTIVE
        /// </param>
        /// <param name="advancementType">
        /// The advancement type of the rolling release<br/>
        /// Example: manual-approval
        /// </param>
        /// <param name="stages">
        /// All stages configured for this rolling release<br/>
        /// Example: [{"index":0,"isFinalStage":false,"targetPercentage":5,"requireApproval":true,"duration":null}, {"index":1,"isFinalStage":false,"targetPercentage":25,"requireApproval":true,"duration":null}, {"index":2,"isFinalStage":false,"targetPercentage":60,"requireApproval":true,"duration":null}, {"index":3,"isFinalStage":true,"targetPercentage":100,"requireApproval":false,"duration":null}]
        /// </param>
        /// <param name="startedAt">
        /// Unix timestamp in milliseconds when the rolling release started<br/>
        /// Example: 1716210500000L
        /// </param>
        /// <param name="updatedAt">
        /// Unix timestamp in milliseconds when the rolling release was last updated<br/>
        /// Example: 1716210600000L
        /// </param>
        /// <param name="substate">
        /// When set to `PAUSED`, the rollout is frozen at the current percentage until continued.
        /// </param>
        /// <param name="currentDeployment">
        /// The current deployment receiving production traffic<br/>
        /// Example: {"id":"dpl_abc123","name":"my-shop@main","url":"my-shop.vercel.app","target":"production","source":"git","createdAt":1716206500000,"readyState":"READY","readyStateAt":1716206800000}
        /// </param>
        /// <param name="canaryDeployment">
        /// The canary deployment being rolled out<br/>
        /// Example: {"id":"dpl_def456","name":"my-shop@9c7e2f4","url":"9c7e2f4-my-shop.vercel.app","target":"production","source":"git","createdAt":1716210100000,"readyState":"READY","readyStateAt":1716210400000}
        /// </param>
        /// <param name="queuedDeploymentId">
        /// The ID of a deployment queued for the next rolling release<br/>
        /// Example: dpl_ghi789
        /// </param>
        /// <param name="activeStage">
        /// The currently active stage, null if the rollout is aborted<br/>
        /// Example: {"index":1,"isFinalStage":false,"targetPercentage":25,"requireApproval":true,"duration":null}
        /// </param>
        /// <param name="nextStage">
        /// The next stage to be activated, null if not in ACTIVE state<br/>
        /// Example: {"index":2,"isFinalStage":false,"targetPercentage":60,"requireApproval":true,"duration":null}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApproveRollingReleaseStageResponseRollingRelease(
            global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseState state,
            global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseAdvancementType advancementType,
            global::System.Collections.Generic.IList<global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseStage> stages,
            double startedAt,
            double updatedAt,
            global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseSubstate? substate,
            global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCurrentDeployment? currentDeployment,
            global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseCanaryDeployment? canaryDeployment,
            string? queuedDeploymentId,
            global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseActiveStage? activeStage,
            global::Vercel.ApproveRollingReleaseStageResponseRollingReleaseNextStage? nextStage)
        {
            this.State = state;
            this.Substate = substate;
            this.CurrentDeployment = currentDeployment;
            this.CanaryDeployment = canaryDeployment;
            this.QueuedDeploymentId = queuedDeploymentId;
            this.AdvancementType = advancementType;
            this.Stages = stages ?? throw new global::System.ArgumentNullException(nameof(stages));
            this.ActiveStage = activeStage;
            this.NextStage = nextStage;
            this.StartedAt = startedAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveRollingReleaseStageResponseRollingRelease" /> class.
        /// </summary>
        public ApproveRollingReleaseStageResponseRollingRelease()
        {
        }
    }
}