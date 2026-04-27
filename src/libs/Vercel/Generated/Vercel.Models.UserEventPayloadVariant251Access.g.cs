
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant251Access
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
    public static class UserEventPayloadVariant251AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant251Access value)
        {
            return value switch
            {
                UserEventPayloadVariant251Access.Private => "private",
                UserEventPayloadVariant251Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant251Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant251Access.Private,
                "public" => UserEventPayloadVariant251Access.Public,
                _ => null,
            };
        }
    }
}