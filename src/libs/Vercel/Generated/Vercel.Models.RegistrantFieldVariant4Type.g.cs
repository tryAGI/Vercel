
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegistrantFieldVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Notice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegistrantFieldVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegistrantFieldVariant4Type value)
        {
            return value switch
            {
                RegistrantFieldVariant4Type.Notice => "notice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegistrantFieldVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "notice" => RegistrantFieldVariant4Type.Notice,
                _ => null,
            };
        }
    }
}