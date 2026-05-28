
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceSourceVariant1Provider
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
    public static class GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceSourceVariant1Provider value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceSourceVariant1Provider.Bitbucket => "bitbucket",
                GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceSourceVariant1Provider.Github => "github",
                GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceSourceVariant1Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceSourceVariant1Provider.Bitbucket,
                "github" => GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceSourceVariant1Provider.Github,
                "gitlab" => GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceSourceVariant1Provider.Gitlab,
                _ => null,
            };
        }
    }
}