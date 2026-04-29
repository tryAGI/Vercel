
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant257Access
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
    public static class UserEventPayloadVariant257AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant257Access value)
        {
            return value switch
            {
                UserEventPayloadVariant257Access.Private => "private",
                UserEventPayloadVariant257Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant257Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant257Access.Private,
                "public" => UserEventPayloadVariant257Access.Public,
                _ => null,
            };
        }
    }
}