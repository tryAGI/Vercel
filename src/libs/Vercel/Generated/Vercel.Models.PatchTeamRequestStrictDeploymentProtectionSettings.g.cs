
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When enabled, deployment protection settings require stricter permissions (owner-only).
    /// </summary>
    public sealed partial class PatchTeamRequestStrictDeploymentProtectionSettings
    {
        /// <summary>
        /// Enable or disable strict deployment protection settings.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestStrictDeploymentProtectionSettings" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Enable or disable strict deployment protection settings.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestStrictDeploymentProtectionSettings(
            bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestStrictDeploymentProtectionSettings" /> class.
        /// </summary>
        public PatchTeamRequestStrictDeploymentProtectionSettings()
        {
        }
    }
}