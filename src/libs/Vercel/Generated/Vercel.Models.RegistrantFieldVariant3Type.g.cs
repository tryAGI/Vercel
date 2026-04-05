
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegistrantFieldVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Acknowledgement,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegistrantFieldVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegistrantFieldVariant3Type value)
        {
            return value switch
            {
                RegistrantFieldVariant3Type.Acknowledgement => "acknowledgement",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegistrantFieldVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "acknowledgement" => RegistrantFieldVariant3Type.Acknowledgement,
                _ => null,
            };
        }
    }
}