
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2Provider
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
    public static class UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2Provider value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2Provider.Bitbucket => "bitbucket",
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2Provider.Github => "github",
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2Provider.Bitbucket,
                "github" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2Provider.Github,
                "gitlab" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourceSourceVariant2Provider.Gitlab,
                _ => null,
            };
        }
    }
}