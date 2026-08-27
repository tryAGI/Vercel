
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1Provider
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
    public static class PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1Provider value)
        {
            return value switch
            {
                PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1Provider.Bitbucket => "bitbucket",
                PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1Provider.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1Provider.Bitbucket,
                "github" => PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemSourceVariant1Provider.Github,
                _ => null,
            };
        }
    }
}