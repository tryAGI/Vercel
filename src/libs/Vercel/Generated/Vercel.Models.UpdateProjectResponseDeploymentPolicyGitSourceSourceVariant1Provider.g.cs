
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider
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
    public static class UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider value)
        {
            return value switch
            {
                UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Bitbucket => "bitbucket",
                UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Github => "github",
                UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Bitbucket,
                "github" => UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Github,
                "gitlab" => UpdateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Gitlab,
                _ => null,
            };
        }
    }
}