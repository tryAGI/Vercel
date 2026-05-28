
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant2Provider
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
    public static class UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant2Provider value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant2Provider.Bitbucket => "bitbucket",
                UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant2Provider.Github => "github",
                UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant2Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant2Provider.Bitbucket,
                "github" => UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant2Provider.Github,
                "gitlab" => UploadProjectAvatarResponseDeploymentPolicyGitSourceSourceVariant2Provider.Gitlab,
                _ => null,
            };
        }
    }
}