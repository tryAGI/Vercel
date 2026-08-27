
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1Provider
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
    public static class UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1Provider value)
        {
            return value switch
            {
                UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1Provider.Bitbucket => "bitbucket",
                UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1Provider.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1Provider.Bitbucket,
                "github" => UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1Provider.Github,
                _ => null,
            };
        }
    }
}