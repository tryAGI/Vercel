
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant240Access
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
    public static class UserEventPayloadVariant240AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant240Access value)
        {
            return value switch
            {
                UserEventPayloadVariant240Access.Private => "private",
                UserEventPayloadVariant240Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant240Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant240Access.Private,
                "public" => UserEventPayloadVariant240Access.Public,
                _ => null,
            };
        }
    }
}