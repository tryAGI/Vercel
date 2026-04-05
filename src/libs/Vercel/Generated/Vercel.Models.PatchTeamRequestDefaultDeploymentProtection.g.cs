
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default deployment protection settings for new projects.
    /// </summary>
    public sealed partial class PatchTeamRequestDefaultDeploymentProtection
    {
        /// <summary>
        /// Allows to protect project deployments with a password
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passwordProtection")]
        public global::Vercel.PatchTeamRequestDefaultDeploymentProtectionPasswordProtection? PasswordProtection { get; set; }

        /// <summary>
        /// Ensures visitors to your Preview Deployments are logged into Vercel and have a minimum of Viewer access on your team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoProtection")]
        public global::Vercel.PatchTeamRequestDefaultDeploymentProtectionSsoProtection? SsoProtection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDefaultDeploymentProtection" /> class.
        /// </summary>
        /// <param name="passwordProtection">
        /// Allows to protect project deployments with a password
        /// </param>
        /// <param name="ssoProtection">
        /// Ensures visitors to your Preview Deployments are logged into Vercel and have a minimum of Viewer access on your team
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequestDefaultDeploymentProtection(
            global::Vercel.PatchTeamRequestDefaultDeploymentProtectionPasswordProtection? passwordProtection,
            global::Vercel.PatchTeamRequestDefaultDeploymentProtectionSsoProtection? ssoProtection)
        {
            this.PasswordProtection = passwordProtection;
            this.SsoProtection = ssoProtection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequestDefaultDeploymentProtection" /> class.
        /// </summary>
        public PatchTeamRequestDefaultDeploymentProtection()
        {
        }
    }
}