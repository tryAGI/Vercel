
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The git provider type associated with gitUserId.
    /// </summary>
    public enum CreateDeploymentResponseVariant2SeatBlockGitProvider
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
    public static class CreateDeploymentResponseVariant2SeatBlockGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2SeatBlockGitProvider value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2SeatBlockGitProvider.Bitbucket => "bitbucket",
                CreateDeploymentResponseVariant2SeatBlockGitProvider.Github => "github",
                CreateDeploymentResponseVariant2SeatBlockGitProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2SeatBlockGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateDeploymentResponseVariant2SeatBlockGitProvider.Bitbucket,
                "github" => CreateDeploymentResponseVariant2SeatBlockGitProvider.Github,
                "gitlab" => CreateDeploymentResponseVariant2SeatBlockGitProvider.Gitlab,
                _ => null,
            };
        }
    }
}