
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant248Access
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
    public static class UserEventPayloadVariant248AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant248Access value)
        {
            return value switch
            {
                UserEventPayloadVariant248Access.Private => "private",
                UserEventPayloadVariant248Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant248Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant248Access.Private,
                "public" => UserEventPayloadVariant248Access.Public,
                _ => null,
            };
        }
    }
}