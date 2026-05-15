
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider
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
    public static class CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider value)
        {
            return value switch
            {
                CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket => "bitbucket",
                CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Github => "github",
                CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket,
                "github" => CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Github,
                "gitlab" => CreateProjectResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab,
                _ => null,
            };
        }
    }
}