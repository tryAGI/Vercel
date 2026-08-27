
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourceSourceVariant1Provider
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
    public static class GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourceSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourceSourceVariant1Provider value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourceSourceVariant1Provider.Bitbucket => "bitbucket",
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourceSourceVariant1Provider.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourceSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourceSourceVariant1Provider.Bitbucket,
                "github" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourceSourceVariant1Provider.Github,
                _ => null,
            };
        }
    }
}