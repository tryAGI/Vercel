
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant1Provider
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
    public static class GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant1Provider value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket => "bitbucket",
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant1Provider.Github => "github",
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket,
                "github" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant1Provider.Github,
                "gitlab" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab,
                _ => null,
            };
        }
    }
}