
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant234Access
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
    public static class UserEventPayloadVariant234AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant234Access value)
        {
            return value switch
            {
                UserEventPayloadVariant234Access.Private => "private",
                UserEventPayloadVariant234Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant234Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant234Access.Private,
                "public" => UserEventPayloadVariant234Access.Public,
                _ => null,
            };
        }
    }
}