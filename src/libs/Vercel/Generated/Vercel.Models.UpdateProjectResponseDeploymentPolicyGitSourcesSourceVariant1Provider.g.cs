
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider
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
    public static class UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider value)
        {
            return value switch
            {
                UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket => "bitbucket",
                UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Github => "github",
                UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket,
                "github" => UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Github,
                "gitlab" => UpdateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab,
                _ => null,
            };
        }
    }
}