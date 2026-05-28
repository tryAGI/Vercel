
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider
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
    public static class UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider value)
        {
            return value switch
            {
                UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider.Bitbucket => "bitbucket",
                UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider.Github => "github",
                UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider.Bitbucket,
                "github" => UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider.Github,
                "gitlab" => UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider.Gitlab,
                _ => null,
            };
        }
    }
}