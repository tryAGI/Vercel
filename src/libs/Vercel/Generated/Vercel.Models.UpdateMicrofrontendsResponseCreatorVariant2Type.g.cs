
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseCreatorVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseCreatorVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseCreatorVariant2Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseCreatorVariant2Type.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseCreatorVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "app" => UpdateMicrofrontendsResponseCreatorVariant2Type.App,
                _ => null,
            };
        }
    }
}