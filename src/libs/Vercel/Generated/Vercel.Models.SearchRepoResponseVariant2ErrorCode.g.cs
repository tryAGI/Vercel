
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchRepoResponseVariant2ErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        InstallationNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRepoResponseVariant2ErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRepoResponseVariant2ErrorCode value)
        {
            return value switch
            {
                SearchRepoResponseVariant2ErrorCode.InstallationNotFound => "installation_not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRepoResponseVariant2ErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "installation_not_found" => SearchRepoResponseVariant2ErrorCode.InstallationNotFound,
                _ => null,
            };
        }
    }
}