
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When enabled, deployment protection settings require stricter permissions (owner-only).
    /// </summary>
    public sealed partial class TeamStrictDeploymentProtectionSettings
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
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamStrictDeploymentProtectionSettings" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamStrictDeploymentProtectionSettings(
            bool enabled,
            double updatedAt)
        {
            this.Enabled = enabled;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamStrictDeploymentProtectionSettings" /> class.
        /// </summary>
        public TeamStrictDeploymentProtectionSettings()
        {
        }
    }
}