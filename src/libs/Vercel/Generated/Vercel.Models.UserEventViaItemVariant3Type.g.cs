
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UserEventViaItemVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        External,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventViaItemVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventViaItemVariant3Type value)
        {
            return value switch
            {
                UserEventViaItemVariant3Type.External => "external",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventViaItemVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "external" => UserEventViaItemVariant3Type.External,
                _ => null,
            };
        }
    }
}