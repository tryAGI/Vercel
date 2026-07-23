
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The git provider type associated with gitUserId.
    /// </summary>
    public enum GetDeploymentResponseVariant2SeatBlockGitProvider
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
    public static class GetDeploymentResponseVariant2SeatBlockGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2SeatBlockGitProvider value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2SeatBlockGitProvider.Bitbucket => "bitbucket",
                GetDeploymentResponseVariant2SeatBlockGitProvider.Github => "github",
                GetDeploymentResponseVariant2SeatBlockGitProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2SeatBlockGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetDeploymentResponseVariant2SeatBlockGitProvider.Bitbucket,
                "github" => GetDeploymentResponseVariant2SeatBlockGitProvider.Github,
                "gitlab" => GetDeploymentResponseVariant2SeatBlockGitProvider.Gitlab,
                _ => null,
            };
        }
    }
}