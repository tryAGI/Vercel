
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider
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
    public static class UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider value)
        {
            return value switch
            {
                UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Bitbucket => "bitbucket",
                UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Github => "github",
                UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Bitbucket,
                "github" => UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Github,
                "gitlab" => UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Gitlab,
                _ => null,
            };
        }
    }
}