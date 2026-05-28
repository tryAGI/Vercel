
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider
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
    public static class GetProjectResponseDeploymentPolicyGitSourceSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider value)
        {
            return value switch
            {
                GetProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Bitbucket => "bitbucket",
                GetProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Github => "github",
                GetProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Bitbucket,
                "github" => GetProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Github,
                "gitlab" => GetProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Gitlab,
                _ => null,
            };
        }
    }
}