
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider
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
    public static class UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider value)
        {
            return value switch
            {
                UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider.Bitbucket => "bitbucket",
                UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider.Github => "github",
                UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider.Bitbucket,
                "github" => UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider.Github,
                "gitlab" => UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider.Gitlab,
                _ => null,
            };
        }
    }
}