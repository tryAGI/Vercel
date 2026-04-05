
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Project-level rolling release configuration that defines how deployments should be gradually rolled out
    /// </summary>
    public sealed partial class UpdateProjectResponseRollingRelease
    {
        /// <summary>
        /// The environment that the release targets, currently only supports production. Adding in case we want to configure with alias groups or custom environments.<br/>
        /// Example: production
        /// </summary>
        /// <example>production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// An array of all the stages required during a deployment release. Each stage defines a target percentage and advancement rules. The final stage must always have targetPercentage: 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stages")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateProjectResponseRollingReleaseStage>? Stages { get; set; }

        /// <summary>
        /// Whether the request served by a canary deployment should return a header indicating a canary was served. Defaults to `false` when omitted.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("canaryResponseHeader")]
        public bool? CanaryResponseHeader { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseRollingRelease" /> class.
        /// </summary>
        /// <param name="target">
        /// The environment that the release targets, currently only supports production. Adding in case we want to configure with alias groups or custom environments.<br/>
        /// Example: production
        /// </param>
        /// <param name="stages">
        /// An array of all the stages required during a deployment release. Each stage defines a target percentage and advancement rules. The final stage must always have targetPercentage: 100.
        /// </param>
        /// <param name="canaryResponseHeader">
        /// Whether the request served by a canary deployment should return a header indicating a canary was served. Defaults to `false` when omitted.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponseRollingRelease(
            string target,
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectResponseRollingReleaseStage>? stages,
            bool? canaryResponseHeader)
        {
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Stages = stages;
            this.CanaryResponseHeader = canaryResponseHeader;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseRollingRelease" /> class.
        /// </summary>
        public UpdateProjectResponseRollingRelease()
        {
        }
    }
}