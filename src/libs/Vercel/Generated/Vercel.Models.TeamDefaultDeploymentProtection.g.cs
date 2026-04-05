
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default deployment protection for this team null indicates protection is disabled
    /// </summary>
    public sealed partial class TeamDefaultDeploymentProtection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passwordProtection")]
        public global::Vercel.TeamDefaultDeploymentProtectionPasswordProtection? PasswordProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoProtection")]
        public global::Vercel.TeamDefaultDeploymentProtectionSsoProtection? SsoProtection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDefaultDeploymentProtection" /> class.
        /// </summary>
        /// <param name="passwordProtection"></param>
        /// <param name="ssoProtection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamDefaultDeploymentProtection(
            global::Vercel.TeamDefaultDeploymentProtectionPasswordProtection? passwordProtection,
            global::Vercel.TeamDefaultDeploymentProtectionSsoProtection? ssoProtection)
        {
            this.PasswordProtection = passwordProtection;
            this.SsoProtection = ssoProtection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDefaultDeploymentProtection" /> class.
        /// </summary>
        public TeamDefaultDeploymentProtection()
        {
        }
    }
}