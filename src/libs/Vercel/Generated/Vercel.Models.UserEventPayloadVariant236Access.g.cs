
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant236Access
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
    public static class UserEventPayloadVariant236AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant236Access value)
        {
            return value switch
            {
                UserEventPayloadVariant236Access.Private => "private",
                UserEventPayloadVariant236Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant236Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant236Access.Private,
                "public" => UserEventPayloadVariant236Access.Public,
                _ => null,
            };
        }
    }
}