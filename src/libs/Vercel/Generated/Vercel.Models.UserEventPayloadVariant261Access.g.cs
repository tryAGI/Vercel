
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant261Access
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
    public static class UserEventPayloadVariant261AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant261Access value)
        {
            return value switch
            {
                UserEventPayloadVariant261Access.Private => "private",
                UserEventPayloadVariant261Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant261Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant261Access.Private,
                "public" => UserEventPayloadVariant261Access.Public,
                _ => null,
            };
        }
    }
}