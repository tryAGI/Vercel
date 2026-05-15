
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamDeploymentPolicyGitSourcesSourceVariant1Provider
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
    public static class TeamDeploymentPolicyGitSourcesSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDeploymentPolicyGitSourcesSourceVariant1Provider value)
        {
            return value switch
            {
                TeamDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket => "bitbucket",
                TeamDeploymentPolicyGitSourcesSourceVariant1Provider.Github => "github",
                TeamDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDeploymentPolicyGitSourcesSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => TeamDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket,
                "github" => TeamDeploymentPolicyGitSourcesSourceVariant1Provider.Github,
                "gitlab" => TeamDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab,
                _ => null,
            };
        }
    }
}