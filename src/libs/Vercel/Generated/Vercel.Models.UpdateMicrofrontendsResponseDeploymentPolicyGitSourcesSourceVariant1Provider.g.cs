
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant1Provider
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
    public static class UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant1Provider value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket => "bitbucket",
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Github => "github",
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Bitbucket,
                "github" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Github,
                "gitlab" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant1Provider.Gitlab,
                _ => null,
            };
        }
    }
}