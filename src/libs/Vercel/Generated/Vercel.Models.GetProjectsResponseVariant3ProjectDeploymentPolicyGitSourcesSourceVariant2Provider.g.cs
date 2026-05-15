
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant2Provider
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
    public static class GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant2Provider value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant2Provider.Bitbucket => "bitbucket",
                GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant2Provider.Github => "github",
                GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant2Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant2Provider.Bitbucket,
                "github" => GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant2Provider.Github,
                "gitlab" => GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesSourceVariant2Provider.Gitlab,
                _ => null,
            };
        }
    }
}