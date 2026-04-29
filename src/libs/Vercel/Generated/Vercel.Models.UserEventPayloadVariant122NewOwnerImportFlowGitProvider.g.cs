
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerImportFlowGitProvider
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
        GithubCustomHost,
        /// <summary>
        /// 
        /// </summary>
        GithubLimited,
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant122NewOwnerImportFlowGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerImportFlowGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerImportFlowGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant122NewOwnerImportFlowGitProvider.Github => "github",
                UserEventPayloadVariant122NewOwnerImportFlowGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant122NewOwnerImportFlowGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant122NewOwnerImportFlowGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant122NewOwnerImportFlowGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerImportFlowGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant122NewOwnerImportFlowGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant122NewOwnerImportFlowGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant122NewOwnerImportFlowGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant122NewOwnerImportFlowGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant122NewOwnerImportFlowGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant122NewOwnerImportFlowGitProvider.Vercel,
                _ => null,
            };
        }
    }
}