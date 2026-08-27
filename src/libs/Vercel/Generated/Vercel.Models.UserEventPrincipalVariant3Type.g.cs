
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UserEventPrincipalVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        External,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPrincipalVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPrincipalVariant3Type value)
        {
            return value switch
            {
                UserEventPrincipalVariant3Type.External => "external",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPrincipalVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "external" => UserEventPrincipalVariant3Type.External,
                _ => null,
            };
        }
    }
}