
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider
    {
        /// <summary>
        ///
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseDeploymentPolicyGitSourceSourceVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider value)
        {
            return value switch
            {
                GetProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => GetProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider.Gitlab,
                _ => null,
            };
        }
    }
}