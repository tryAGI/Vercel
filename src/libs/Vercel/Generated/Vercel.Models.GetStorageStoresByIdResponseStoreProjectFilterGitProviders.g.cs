
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetStorageStoresByIdResponseStoreProjectFilterGitProviders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetStorageStoresByIdResponseStoreProjectFilterGitProvidersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageStoresByIdResponseStoreProjectFilterGitProviders value)
        {
            return value switch
            {
                GetStorageStoresByIdResponseStoreProjectFilterGitProviders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageStoresByIdResponseStoreProjectFilterGitProviders? ToEnum(string value)
        {
            return value switch
            {
                "*" => GetStorageStoresByIdResponseStoreProjectFilterGitProviders.Multiply,
                _ => null,
            };
        }
    }
}