
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAttackChallengeModeRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attackModeEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AttackModeEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAttackChallengeModeRequestVariant2" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="attackModeEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAttackChallengeModeRequestVariant2(
            string projectId,
            bool attackModeEnabled)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.AttackModeEnabled = attackModeEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAttackChallengeModeRequestVariant2" /> class.
        /// </summary>
        public UpdateAttackChallengeModeRequestVariant2()
        {
        }
    }
}