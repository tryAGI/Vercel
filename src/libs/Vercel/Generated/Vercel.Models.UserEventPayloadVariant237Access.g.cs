
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant237Access
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
    public static class UserEventPayloadVariant237AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant237Access value)
        {
            return value switch
            {
                UserEventPayloadVariant237Access.Private => "private",
                UserEventPayloadVariant237Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant237Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant237Access.Private,
                "public" => UserEventPayloadVariant237Access.Public,
                _ => null,
            };
        }
    }
}