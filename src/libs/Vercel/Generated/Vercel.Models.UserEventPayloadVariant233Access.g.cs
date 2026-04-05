
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant233Access
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
    public static class UserEventPayloadVariant233AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant233Access value)
        {
            return value switch
            {
                UserEventPayloadVariant233Access.Private => "private",
                UserEventPayloadVariant233Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant233Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant233Access.Private,
                "public" => UserEventPayloadVariant233Access.Public,
                _ => null,
            };
        }
    }
}