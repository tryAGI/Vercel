
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant245Access
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
    public static class UserEventPayloadVariant245AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant245Access value)
        {
            return value switch
            {
                UserEventPayloadVariant245Access.Private => "private",
                UserEventPayloadVariant245Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant245Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant245Access.Private,
                "public" => UserEventPayloadVariant245Access.Public,
                _ => null,
            };
        }
    }
}