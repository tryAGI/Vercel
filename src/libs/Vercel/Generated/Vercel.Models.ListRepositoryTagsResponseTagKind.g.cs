
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRepositoryTagsResponseTagKind
    {
        /// <summary>
        /// 
        /// </summary>
        Index,
        /// <summary>
        /// 
        /// </summary>
        Manifest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRepositoryTagsResponseTagKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRepositoryTagsResponseTagKind value)
        {
            return value switch
            {
                ListRepositoryTagsResponseTagKind.Index => "index",
                ListRepositoryTagsResponseTagKind.Manifest => "manifest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRepositoryTagsResponseTagKind? ToEnum(string value)
        {
            return value switch
            {
                "index" => ListRepositoryTagsResponseTagKind.Index,
                "manifest" => ListRepositoryTagsResponseTagKind.Manifest,
                _ => null,
            };
        }
    }
}