
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant250Access
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
    public static class UserEventPayloadVariant250AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant250Access value)
        {
            return value switch
            {
                UserEventPayloadVariant250Access.Private => "private",
                UserEventPayloadVariant250Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant250Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant250Access.Private,
                "public" => UserEventPayloadVariant250Access.Public,
                _ => null,
            };
        }
    }
}