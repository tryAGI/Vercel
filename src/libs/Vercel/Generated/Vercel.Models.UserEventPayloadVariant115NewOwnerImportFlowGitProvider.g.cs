
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerImportFlowGitProvider
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
    public static class UserEventPayloadVariant115NewOwnerImportFlowGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerImportFlowGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerImportFlowGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant115NewOwnerImportFlowGitProvider.Github => "github",
                UserEventPayloadVariant115NewOwnerImportFlowGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant115NewOwnerImportFlowGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant115NewOwnerImportFlowGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant115NewOwnerImportFlowGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerImportFlowGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant115NewOwnerImportFlowGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant115NewOwnerImportFlowGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant115NewOwnerImportFlowGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant115NewOwnerImportFlowGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant115NewOwnerImportFlowGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant115NewOwnerImportFlowGitProvider.Vercel,
                _ => null,
            };
        }
    }
}