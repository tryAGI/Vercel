
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseLinkVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        CursorOrigin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseLinkVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseLinkVariant7Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseLinkVariant7Type.CursorOrigin => "cursor-origin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseLinkVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "cursor-origin" => UpdateMicrofrontendsResponseLinkVariant7Type.CursorOrigin,
                _ => null,
            };
        }
    }
}