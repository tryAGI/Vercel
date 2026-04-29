
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant259Access
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
    public static class UserEventPayloadVariant259AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant259Access value)
        {
            return value switch
            {
                UserEventPayloadVariant259Access.Private => "private",
                UserEventPayloadVariant259Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant259Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant259Access.Private,
                "public" => UserEventPayloadVariant259Access.Public,
                _ => null,
            };
        }
    }
}