
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant2Provider
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
    public static class UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant2Provider value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Bitbucket => "bitbucket",
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Github => "github",
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Bitbucket,
                "github" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Github,
                "gitlab" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesSourceVariant2Provider.Gitlab,
                _ => null,
            };
        }
    }
}