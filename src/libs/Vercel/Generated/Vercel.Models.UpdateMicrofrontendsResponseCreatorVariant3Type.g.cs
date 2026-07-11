
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseCreatorVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseCreatorVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseCreatorVariant3Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseCreatorVariant3Type.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseCreatorVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "integration" => UpdateMicrofrontendsResponseCreatorVariant3Type.Integration,
                _ => null,
            };
        }
    }
}