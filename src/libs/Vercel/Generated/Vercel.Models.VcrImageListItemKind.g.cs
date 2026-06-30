
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the manifest is a multi-platform image index or a single-platform image manifest.
    /// </summary>
    public enum VcrImageListItemKind
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
    public static class VcrImageListItemKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VcrImageListItemKind value)
        {
            return value switch
            {
                VcrImageListItemKind.Index => "index",
                VcrImageListItemKind.Manifest => "manifest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VcrImageListItemKind? ToEnum(string value)
        {
            return value switch
            {
                "index" => VcrImageListItemKind.Index,
                "manifest" => VcrImageListItemKind.Manifest,
                _ => null,
            };
        }
    }
}