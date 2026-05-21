
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant1Provider
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
    public static class GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant1Provider value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket => "bitbucket",
                GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant1Provider.Github => "github",
                GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket,
                "github" => GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant1Provider.Github,
                "gitlab" => GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab,
                _ => null,
            };
        }
    }
}