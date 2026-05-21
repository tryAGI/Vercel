
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant2Provider
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
    public static class GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant2Provider value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant2Provider.Bitbucket => "bitbucket",
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant2Provider.Github => "github",
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant2Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant2Provider.Bitbucket,
                "github" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant2Provider.Github,
                "gitlab" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourcesSourceVariant2Provider.Gitlab,
                _ => null,
            };
        }
    }
}