
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2Provider
    {
        /// <summary>
        ///
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2Provider value)
        {
            return value switch
            {
                UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2Provider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant2Provider.Gitlab,
                _ => null,
            };
        }
    }
}