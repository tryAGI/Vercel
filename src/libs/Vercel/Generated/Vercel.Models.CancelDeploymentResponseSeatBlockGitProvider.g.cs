
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The git provider type associated with gitUserId.
    /// </summary>
    public enum CancelDeploymentResponseSeatBlockGitProvider
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
    public static class CancelDeploymentResponseSeatBlockGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseSeatBlockGitProvider value)
        {
            return value switch
            {
                CancelDeploymentResponseSeatBlockGitProvider.Bitbucket => "bitbucket",
                CancelDeploymentResponseSeatBlockGitProvider.Github => "github",
                CancelDeploymentResponseSeatBlockGitProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseSeatBlockGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CancelDeploymentResponseSeatBlockGitProvider.Bitbucket,
                "github" => CancelDeploymentResponseSeatBlockGitProvider.Github,
                "gitlab" => CancelDeploymentResponseSeatBlockGitProvider.Gitlab,
                _ => null,
            };
        }
    }
}