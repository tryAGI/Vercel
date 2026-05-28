
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant1Provider
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
    public static class UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant1Provider value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket => "bitbucket",
                UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Github => "github",
                UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket,
                "github" => UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Github,
                "gitlab" => UploadProjectAvatarResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab,
                _ => null,
            };
        }
    }
}