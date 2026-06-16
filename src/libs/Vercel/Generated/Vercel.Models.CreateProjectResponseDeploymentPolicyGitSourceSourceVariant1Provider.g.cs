
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseDeploymentPolicyGitSourceSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider value)
        {
            return value switch
            {
                CreateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Bitbucket => "bitbucket",
                CreateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Bitbucket,
                "github" => CreateProjectResponseDeploymentPolicyGitSourceSourceVariant1Provider.Github,
                _ => null,
            };
        }
    }
}