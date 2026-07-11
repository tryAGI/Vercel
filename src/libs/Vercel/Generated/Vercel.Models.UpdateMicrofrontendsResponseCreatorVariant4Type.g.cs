
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseCreatorVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseCreatorVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseCreatorVariant4Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseCreatorVariant4Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseCreatorVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => UpdateMicrofrontendsResponseCreatorVariant4Type.System,
                _ => null,
            };
        }
    }
}