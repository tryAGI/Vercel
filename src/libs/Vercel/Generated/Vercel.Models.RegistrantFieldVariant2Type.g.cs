
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegistrantFieldVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Enum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegistrantFieldVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegistrantFieldVariant2Type value)
        {
            return value switch
            {
                RegistrantFieldVariant2Type.Enum => "enum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegistrantFieldVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "enum" => RegistrantFieldVariant2Type.Enum,
                _ => null,
            };
        }
    }
}