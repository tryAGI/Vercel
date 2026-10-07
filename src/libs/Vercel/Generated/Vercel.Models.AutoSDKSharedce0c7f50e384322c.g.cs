
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Project-level rolling release configuration that defines how deployments should be gradually rolled out
    /// </summary>
    public sealed partial class AutoSDKSharedce0c7f50e384322c
    {
        /// <summary>
        /// Whether the request served by a canary deployment should return a header indicating a canary was served. Defaults to `false` when omitted.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("canaryResponseHeader")]
        public bool? CanaryResponseHeader { get; set; }

        /// <summary>
        /// Automated gating configuration. Omitted (the default) means no gating is configured, which is equivalent to `enabled: false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gate")]
        public global::Vercel.AutoSDKSharedf29c7949a8a48e4a? Gate { get; set; }

        /// <summary>
        /// An array of all the stages required during a deployment release. Each stage defines a target percentage and advancement rules. The final stage must always have targetPercentage: 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stages")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedce0c7f50e384322cStage>? Stages { get; set; }

        /// <summary>
        /// The environment that the release targets, currently only supports production. Adding in case we want to configure with alias groups or custom environments.<br/>
        /// Example: production
        /// </summary>
        /// <example>production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedce0c7f50e384322c" /> class.
        /// </summary>
        /// <param name="target">
        /// The environment that the release targets, currently only supports production. Adding in case we want to configure with alias groups or custom environments.<br/>
        /// Example: production
        /// </param>
        /// <param name="canaryResponseHeader">
        /// Whether the request served by a canary deployment should return a header indicating a canary was served. Defaults to `false` when omitted.<br/>
        /// Example: false
        /// </param>
        /// <param name="gate">
        /// Automated gating configuration. Omitted (the default) means no gating is configured, which is equivalent to `enabled: false`.
        /// </param>
        /// <param name="stages">
        /// An array of all the stages required during a deployment release. Each stage defines a target percentage and advancement rules. The final stage must always have targetPercentage: 100.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedce0c7f50e384322c(
            string target,
            bool? canaryResponseHeader,
            global::Vercel.AutoSDKSharedf29c7949a8a48e4a? gate,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedce0c7f50e384322cStage>? stages)
        {
            this.CanaryResponseHeader = canaryResponseHeader;
            this.Gate = gate;
            this.Stages = stages;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedce0c7f50e384322c" /> class.
        /// </summary>
        public AutoSDKSharedce0c7f50e384322c()
        {
        }

    }
}