
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider
    {
        /// <summary>
        ///
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseDeploymentPolicyGitSourceSourceVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider value)
        {
            return value switch
            {
                CreateProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => CreateProjectResponseDeploymentPolicyGitSourceSourceVariant2Provider.Gitlab,
                _ => null,
            };
        }
    }
}