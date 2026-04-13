
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerImportFlowGitProvider
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
    public static class UserEventPayloadVariant116NewOwnerImportFlowGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerImportFlowGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerImportFlowGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant116NewOwnerImportFlowGitProvider.Github => "github",
                UserEventPayloadVariant116NewOwnerImportFlowGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant116NewOwnerImportFlowGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant116NewOwnerImportFlowGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant116NewOwnerImportFlowGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerImportFlowGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant116NewOwnerImportFlowGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant116NewOwnerImportFlowGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant116NewOwnerImportFlowGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant116NewOwnerImportFlowGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant116NewOwnerImportFlowGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant116NewOwnerImportFlowGitProvider.Vercel,
                _ => null,
            };
        }
    }
}