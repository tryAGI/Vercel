
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant238Access
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
    public static class UserEventPayloadVariant238AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant238Access value)
        {
            return value switch
            {
                UserEventPayloadVariant238Access.Private => "private",
                UserEventPayloadVariant238Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant238Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant238Access.Private,
                "public" => UserEventPayloadVariant238Access.Public,
                _ => null,
            };
        }
    }
}