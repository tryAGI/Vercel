
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestDeploymentPolicyGitSourcesSourceProvider
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
    public static class UpdateProjectRequestDeploymentPolicyGitSourcesSourceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestDeploymentPolicyGitSourcesSourceProvider value)
        {
            return value switch
            {
                UpdateProjectRequestDeploymentPolicyGitSourcesSourceProvider.Bitbucket => "bitbucket",
                UpdateProjectRequestDeploymentPolicyGitSourcesSourceProvider.Github => "github",
                UpdateProjectRequestDeploymentPolicyGitSourcesSourceProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestDeploymentPolicyGitSourcesSourceProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UpdateProjectRequestDeploymentPolicyGitSourcesSourceProvider.Bitbucket,
                "github" => UpdateProjectRequestDeploymentPolicyGitSourcesSourceProvider.Github,
                "gitlab" => UpdateProjectRequestDeploymentPolicyGitSourcesSourceProvider.Gitlab,
                _ => null,
            };
        }
    }
}