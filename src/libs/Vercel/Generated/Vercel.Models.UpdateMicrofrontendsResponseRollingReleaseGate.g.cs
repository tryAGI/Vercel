
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Automated gating configuration. Omitted (the default) means no gating is configured, which is equivalent to `enabled: false`.
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseRollingReleaseGate
    {
        /// <summary>
        /// Whether automated gating is enabled for this project's rollouts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// The checks to evaluate. An empty array means nothing is evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateMicrofrontendsResponseRollingReleaseGateCheck> Checks { get; set; }

        /// <summary>
        /// How many failing evaluations within {@link windowSize} trip the gate. Defaults to `3` when omitted.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureThreshold")]
        public double? FailureThreshold { get; set; }

        /// <summary>
        /// How many of the most recent evaluations {@link failureThreshold} is counted against. Defaults to `5` when omitted.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("windowSize")]
        public double? WindowSize { get; set; }

        /// <summary>
        /// What to do when the gate trips: pause the rollout, or roll it back.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateMicrofrontendsResponseRollingReleaseGateActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateMicrofrontendsResponseRollingReleaseGateAction Action { get; set; }

        /// <summary>
        /// When true, a tripped gate is only reported — {@link action} is not taken.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dryRun")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DryRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseRollingReleaseGate" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether automated gating is enabled for this project's rollouts.
        /// </param>
        /// <param name="checks">
        /// The checks to evaluate. An empty array means nothing is evaluated.
        /// </param>
        /// <param name="action">
        /// What to do when the gate trips: pause the rollout, or roll it back.
        /// </param>
        /// <param name="dryRun">
        /// When true, a tripped gate is only reported — {@link action} is not taken.
        /// </param>
        /// <param name="failureThreshold">
        /// How many failing evaluations within {@link windowSize} trip the gate. Defaults to `3` when omitted.<br/>
        /// Example: 3
        /// </param>
        /// <param name="windowSize">
        /// How many of the most recent evaluations {@link failureThreshold} is counted against. Defaults to `5` when omitted.<br/>
        /// Example: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsResponseRollingReleaseGate(
            bool enabled,
            global::System.Collections.Generic.IList<global::Vercel.UpdateMicrofrontendsResponseRollingReleaseGateCheck> checks,
            global::Vercel.UpdateMicrofrontendsResponseRollingReleaseGateAction action,
            bool dryRun,
            double? failureThreshold,
            double? windowSize)
        {
            this.Enabled = enabled;
            this.Checks = checks ?? throw new global::System.ArgumentNullException(nameof(checks));
            this.FailureThreshold = failureThreshold;
            this.WindowSize = windowSize;
            this.Action = action;
            this.DryRun = dryRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseRollingReleaseGate" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseRollingReleaseGate()
        {
        }

    }
}