
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseLinkVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        CursorOrigin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseLinkVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseLinkVariant7Type value)
        {
            return value switch
            {
                GetProjectResponseLinkVariant7Type.CursorOrigin => "cursor-origin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseLinkVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "cursor-origin" => GetProjectResponseLinkVariant7Type.CursorOrigin,
                _ => null,
            };
        }
    }
}