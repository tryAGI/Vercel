
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetStorageStoresByIdResponseStoreProjectFilterGitProvider
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
    public static class GetStorageStoresByIdResponseStoreProjectFilterGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageStoresByIdResponseStoreProjectFilterGitProvider value)
        {
            return value switch
            {
                GetStorageStoresByIdResponseStoreProjectFilterGitProvider.Bitbucket => "bitbucket",
                GetStorageStoresByIdResponseStoreProjectFilterGitProvider.Github => "github",
                GetStorageStoresByIdResponseStoreProjectFilterGitProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageStoresByIdResponseStoreProjectFilterGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetStorageStoresByIdResponseStoreProjectFilterGitProvider.Bitbucket,
                "github" => GetStorageStoresByIdResponseStoreProjectFilterGitProvider.Github,
                "gitlab" => GetStorageStoresByIdResponseStoreProjectFilterGitProvider.Gitlab,
                _ => null,
            };
        }
    }
}