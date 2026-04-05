
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProjectFilterGitProvider
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
    public static class CreateIntegrationStoreDirectResponseStoreProjectFilterGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProjectFilterGitProvider value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProjectFilterGitProvider.Bitbucket => "bitbucket",
                CreateIntegrationStoreDirectResponseStoreProjectFilterGitProvider.Github => "github",
                CreateIntegrationStoreDirectResponseStoreProjectFilterGitProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProjectFilterGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateIntegrationStoreDirectResponseStoreProjectFilterGitProvider.Bitbucket,
                "github" => CreateIntegrationStoreDirectResponseStoreProjectFilterGitProvider.Github,
                "gitlab" => CreateIntegrationStoreDirectResponseStoreProjectFilterGitProvider.Gitlab,
                _ => null,
            };
        }
    }
}