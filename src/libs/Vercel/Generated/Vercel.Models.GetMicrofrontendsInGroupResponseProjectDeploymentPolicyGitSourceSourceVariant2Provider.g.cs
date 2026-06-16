
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourceSourceVariant2Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourceSourceVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourceSourceVariant2Provider value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourceSourceVariant2Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourceSourceVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyGitSourceSourceVariant2Provider.Gitlab,
                _ => null,
            };
        }
    }
}