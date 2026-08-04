
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectLinkVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        CursorOrigin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectLinkVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectLinkVariant7Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectLinkVariant7Type.CursorOrigin => "cursor-origin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectLinkVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "cursor-origin" => GetProjectsResponseVariant2ProjectLinkVariant7Type.CursorOrigin,
                _ => null,
            };
        }
    }
}