
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum TeamDeploymentPolicyGitSourceSourceVariant1Provider
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
    public static class TeamDeploymentPolicyGitSourceSourceVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDeploymentPolicyGitSourceSourceVariant1Provider value)
        {
            return value switch
            {
                TeamDeploymentPolicyGitSourceSourceVariant1Provider.Bitbucket => "bitbucket",
                TeamDeploymentPolicyGitSourceSourceVariant1Provider.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDeploymentPolicyGitSourceSourceVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => TeamDeploymentPolicyGitSourceSourceVariant1Provider.Bitbucket,
                "github" => TeamDeploymentPolicyGitSourceSourceVariant1Provider.Github,
                _ => null,
            };
        }
    }
}