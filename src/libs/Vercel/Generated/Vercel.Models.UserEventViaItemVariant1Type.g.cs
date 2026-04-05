
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventViaItemVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventViaItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventViaItemVariant1Type value)
        {
            return value switch
            {
                UserEventViaItemVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventViaItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "user" => UserEventViaItemVariant1Type.User,
                _ => null,
            };
        }
    }
}