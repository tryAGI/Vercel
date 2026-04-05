
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPrincipalVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPrincipalVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPrincipalVariant1Type value)
        {
            return value switch
            {
                UserEventPrincipalVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPrincipalVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "user" => UserEventPrincipalVariant1Type.User,
                _ => null,
            };
        }
    }
}