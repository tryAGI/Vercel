
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchRepoResponseVariant3RepoProvider
    {
        /// <summary>
        ///
        /// </summary>
        CursorOrigin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRepoResponseVariant3RepoProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRepoResponseVariant3RepoProvider value)
        {
            return value switch
            {
                SearchRepoResponseVariant3RepoProvider.CursorOrigin => "cursor-origin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRepoResponseVariant3RepoProvider? ToEnum(string value)
        {
            return value switch
            {
                "cursor-origin" => SearchRepoResponseVariant3RepoProvider.CursorOrigin,
                _ => null,
            };
        }
    }
}