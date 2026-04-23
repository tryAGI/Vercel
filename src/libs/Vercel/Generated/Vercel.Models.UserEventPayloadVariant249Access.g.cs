
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant249Access
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
    public static class UserEventPayloadVariant249AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant249Access value)
        {
            return value switch
            {
                UserEventPayloadVariant249Access.Private => "private",
                UserEventPayloadVariant249Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant249Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant249Access.Private,
                "public" => UserEventPayloadVariant249Access.Public,
                _ => null,
            };
        }
    }
}