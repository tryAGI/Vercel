
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant258Access
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
    public static class UserEventPayloadVariant258AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant258Access value)
        {
            return value switch
            {
                UserEventPayloadVariant258Access.Private => "private",
                UserEventPayloadVariant258Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant258Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant258Access.Private,
                "public" => UserEventPayloadVariant258Access.Public,
                _ => null,
            };
        }
    }
}