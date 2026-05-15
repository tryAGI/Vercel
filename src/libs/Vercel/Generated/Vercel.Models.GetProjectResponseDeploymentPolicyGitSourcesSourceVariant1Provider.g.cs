
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider
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
    public static class GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider value)
        {
            return value switch
            {
                GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket => "bitbucket",
                GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Github => "github",
                GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket,
                "github" => GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Github,
                "gitlab" => GetProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab,
                _ => null,
            };
        }
    }
}