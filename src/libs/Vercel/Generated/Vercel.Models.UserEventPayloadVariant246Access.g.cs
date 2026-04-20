
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant246Access
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
    public static class UserEventPayloadVariant246AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant246Access value)
        {
            return value switch
            {
                UserEventPayloadVariant246Access.Private => "private",
                UserEventPayloadVariant246Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant246Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant246Access.Private,
                "public" => UserEventPayloadVariant246Access.Public,
                _ => null,
            };
        }
    }
}