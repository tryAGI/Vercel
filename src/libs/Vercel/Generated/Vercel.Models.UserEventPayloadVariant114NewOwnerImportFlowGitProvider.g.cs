
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerImportFlowGitProvider
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
    public static class UserEventPayloadVariant114NewOwnerImportFlowGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerImportFlowGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerImportFlowGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant114NewOwnerImportFlowGitProvider.Github => "github",
                UserEventPayloadVariant114NewOwnerImportFlowGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant114NewOwnerImportFlowGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant114NewOwnerImportFlowGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant114NewOwnerImportFlowGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerImportFlowGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant114NewOwnerImportFlowGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant114NewOwnerImportFlowGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant114NewOwnerImportFlowGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant114NewOwnerImportFlowGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant114NewOwnerImportFlowGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant114NewOwnerImportFlowGitProvider.Vercel,
                _ => null,
            };
        }
    }
}