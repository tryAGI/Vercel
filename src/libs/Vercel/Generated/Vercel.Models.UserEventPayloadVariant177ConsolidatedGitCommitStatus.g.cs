
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant177ConsolidatedGitCommitStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propagateFailures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PropagateFailures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant177ConsolidatedGitCommitStatus" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="propagateFailures"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant177ConsolidatedGitCommitStatus(
            bool enabled,
            bool propagateFailures)
        {
            this.Enabled = enabled;
            this.PropagateFailures = propagateFailures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant177ConsolidatedGitCommitStatus" /> class.
        /// </summary>
        public UserEventPayloadVariant177ConsolidatedGitCommitStatus()
        {
        }
    }
}