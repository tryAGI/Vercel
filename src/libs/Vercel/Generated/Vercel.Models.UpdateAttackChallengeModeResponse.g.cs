
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAttackChallengeModeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attackModeEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AttackModeEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attackModeUpdatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AttackModeUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAttackChallengeModeResponse" /> class.
        /// </summary>
        /// <param name="attackModeEnabled"></param>
        /// <param name="attackModeUpdatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAttackChallengeModeResponse(
            bool attackModeEnabled,
            double attackModeUpdatedAt)
        {
            this.AttackModeEnabled = attackModeEnabled;
            this.AttackModeUpdatedAt = attackModeUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAttackChallengeModeResponse" /> class.
        /// </summary>
        public UpdateAttackChallengeModeResponse()
        {
        }
    }
}