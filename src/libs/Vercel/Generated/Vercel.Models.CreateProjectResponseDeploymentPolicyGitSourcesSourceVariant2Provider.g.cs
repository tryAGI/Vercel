
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider
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
    public static class CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider value)
        {
            return value switch
            {
                CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Bitbucket => "bitbucket",
                CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Github => "github",
                CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Bitbucket,
                "github" => CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Github,
                "gitlab" => CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Gitlab,
                _ => null,
            };
        }
    }
}