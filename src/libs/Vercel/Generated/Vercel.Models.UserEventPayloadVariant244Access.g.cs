
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant244Access
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
    public static class UserEventPayloadVariant244AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant244Access value)
        {
            return value switch
            {
                UserEventPayloadVariant244Access.Private => "private",
                UserEventPayloadVariant244Access.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant244Access? ToEnum(string value)
        {
            return value switch
            {
                "private" => UserEventPayloadVariant244Access.Private,
                "public" => UserEventPayloadVariant244Access.Public,
                _ => null,
            };
        }
    }
}