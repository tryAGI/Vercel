
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateStorageStoresBlobResponseStoreProjectFilterGitProvider
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
    public static class CreateStorageStoresBlobResponseStoreProjectFilterGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStorageStoresBlobResponseStoreProjectFilterGitProvider value)
        {
            return value switch
            {
                CreateStorageStoresBlobResponseStoreProjectFilterGitProvider.Bitbucket => "bitbucket",
                CreateStorageStoresBlobResponseStoreProjectFilterGitProvider.Github => "github",
                CreateStorageStoresBlobResponseStoreProjectFilterGitProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStorageStoresBlobResponseStoreProjectFilterGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateStorageStoresBlobResponseStoreProjectFilterGitProvider.Bitbucket,
                "github" => CreateStorageStoresBlobResponseStoreProjectFilterGitProvider.Github,
                "gitlab" => CreateStorageStoresBlobResponseStoreProjectFilterGitProvider.Gitlab,
                _ => null,
            };
        }
    }
}