
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The git provider type associated with gitUserId.
    /// </summary>
    public enum GetDeploymentsResponseDeploymentSeatBlockGitProvider
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
    public static class GetDeploymentsResponseDeploymentSeatBlockGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentSeatBlockGitProvider value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentSeatBlockGitProvider.Bitbucket => "bitbucket",
                GetDeploymentsResponseDeploymentSeatBlockGitProvider.Github => "github",
                GetDeploymentsResponseDeploymentSeatBlockGitProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentSeatBlockGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetDeploymentsResponseDeploymentSeatBlockGitProvider.Bitbucket,
                "github" => GetDeploymentsResponseDeploymentSeatBlockGitProvider.Github,
                "gitlab" => GetDeploymentsResponseDeploymentSeatBlockGitProvider.Gitlab,
                _ => null,
            };
        }
    }
}