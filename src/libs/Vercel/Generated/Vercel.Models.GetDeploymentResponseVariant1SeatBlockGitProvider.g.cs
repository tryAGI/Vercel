
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The git provider type associated with gitUserId.
    /// </summary>
    public enum GetDeploymentResponseVariant1SeatBlockGitProvider
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
    public static class GetDeploymentResponseVariant1SeatBlockGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1SeatBlockGitProvider value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1SeatBlockGitProvider.Bitbucket => "bitbucket",
                GetDeploymentResponseVariant1SeatBlockGitProvider.Github => "github",
                GetDeploymentResponseVariant1SeatBlockGitProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1SeatBlockGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetDeploymentResponseVariant1SeatBlockGitProvider.Bitbucket,
                "github" => GetDeploymentResponseVariant1SeatBlockGitProvider.Github,
                "gitlab" => GetDeploymentResponseVariant1SeatBlockGitProvider.Gitlab,
                _ => null,
            };
        }
    }
}