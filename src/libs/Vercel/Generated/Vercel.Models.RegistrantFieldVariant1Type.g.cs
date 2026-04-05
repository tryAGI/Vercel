
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegistrantFieldVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegistrantFieldVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegistrantFieldVariant1Type value)
        {
            return value switch
            {
                RegistrantFieldVariant1Type.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegistrantFieldVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "string" => RegistrantFieldVariant1Type.String,
                _ => null,
            };
        }
    }
}