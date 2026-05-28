
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant2Provider
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
    public static class UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant2Provider value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Bitbucket => "bitbucket",
                UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Github => "github",
                UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Bitbucket,
                "github" => UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Github,
                "gitlab" => UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Gitlab,
                _ => null,
            };
        }
    }
}