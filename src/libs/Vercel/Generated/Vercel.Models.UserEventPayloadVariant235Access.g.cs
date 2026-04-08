
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant235Access
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
    public static class UserEventPayloadVariant235AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant235Access value)
        {
            return value switch
            {
                UserEventPayloadVariant235Access.Private => "private",
                UserEventPayloadVariant235Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant235Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant235Access.Private,
                "public" => UserEventPayloadVariant235Access.Public,
                _ => null,
            };
        }
    }
}