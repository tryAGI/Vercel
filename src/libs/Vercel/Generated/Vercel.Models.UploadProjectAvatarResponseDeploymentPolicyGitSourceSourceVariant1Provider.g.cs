
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant1Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant1Provider value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant1Provider.Bitbucket => "bitbucket",
                UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant1Provider.Github => "github",
                UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant1Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant1Provider.Bitbucket,
                "github" => UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant1Provider.Github,
                "gitlab" => UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant1Provider.Gitlab,
                _ => null,
            };
        }
    }
}