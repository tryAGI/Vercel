
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant247Access
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
    public static class UserEventPayloadVariant247AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant247Access value)
        {
            return value switch
            {
                UserEventPayloadVariant247Access.Private => "private",
                UserEventPayloadVariant247Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant247Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant247Access.Private,
                "public" => UserEventPayloadVariant247Access.Public,
                _ => null,
            };
        }
    }
}