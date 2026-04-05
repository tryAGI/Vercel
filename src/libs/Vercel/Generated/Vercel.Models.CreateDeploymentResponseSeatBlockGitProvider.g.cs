
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The git provider type associated with gitUserId.
    /// </summary>
    public enum CreateDeploymentResponseSeatBlockGitProvider
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
    public static class CreateDeploymentResponseSeatBlockGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseSeatBlockGitProvider value)
        {
            return value switch
            {
                CreateDeploymentResponseSeatBlockGitProvider.Bitbucket => "bitbucket",
                CreateDeploymentResponseSeatBlockGitProvider.Github => "github",
                CreateDeploymentResponseSeatBlockGitProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseSeatBlockGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateDeploymentResponseSeatBlockGitProvider.Bitbucket,
                "github" => CreateDeploymentResponseSeatBlockGitProvider.Github,
                "gitlab" => CreateDeploymentResponseSeatBlockGitProvider.Gitlab,
                _ => null,
            };
        }
    }
}