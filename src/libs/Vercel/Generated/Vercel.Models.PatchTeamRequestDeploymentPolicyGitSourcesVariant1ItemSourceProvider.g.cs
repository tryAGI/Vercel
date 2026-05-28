
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider
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
    public static class PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider value)
        {
            return value switch
            {
                PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider.Bitbucket => "bitbucket",
                PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider.Github => "github",
                PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider.Bitbucket,
                "github" => PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider.Github,
                "gitlab" => PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceProvider.Gitlab,
                _ => null,
            };
        }
    }
}