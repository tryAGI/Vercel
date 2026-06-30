
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Field to sort the non-pinned tags by.<br/>
    /// Default Value: updatedAt
    /// </summary>
    public enum ListRepositoryTagsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Tag,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRepositoryTagsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRepositoryTagsSortBy value)
        {
            return value switch
            {
                ListRepositoryTagsSortBy.Tag => "tag",
                ListRepositoryTagsSortBy.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRepositoryTagsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "tag" => ListRepositoryTagsSortBy.Tag,
                "updatedAt" => ListRepositoryTagsSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}