
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant239Access
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant239AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant239Access value)
        {
            return value switch
            {
                UserEventPayloadVariant239Access.Private => "private",
                UserEventPayloadVariant239Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant239Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant239Access.Private,
                "public" => UserEventPayloadVariant239Access.Public,
                _ => null,
            };
        }
    }
}