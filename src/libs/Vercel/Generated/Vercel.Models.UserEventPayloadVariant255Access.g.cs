
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant255Access
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
    public static class UserEventPayloadVariant255AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant255Access value)
        {
            return value switch
            {
                UserEventPayloadVariant255Access.Private => "private",
                UserEventPayloadVariant255Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant255Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant255Access.Private,
                "public" => UserEventPayloadVariant255Access.Public,
                _ => null,
            };
        }
    }
}