
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider
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
    public static class GetProjectResponseDeploymentPolicyGitSourcesSourceVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider value)
        {
            return value switch
            {
                GetProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Bitbucket => "bitbucket",
                GetProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Github => "github",
                GetProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Bitbucket,
                "github" => GetProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Github,
                "gitlab" => GetProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Gitlab,
                _ => null,
            };
        }
    }
}