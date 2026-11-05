
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UserEventPrincipalVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPrincipalVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPrincipalVariant5Type value)
        {
            return value switch
            {
                UserEventPrincipalVariant5Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPrincipalVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => UserEventPrincipalVariant5Type.System,
                _ => null,
            };
        }
    }
}