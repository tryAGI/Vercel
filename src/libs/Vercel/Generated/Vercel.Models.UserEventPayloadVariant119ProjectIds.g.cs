
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant119ProjectIds
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant119ProjectIdsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant119ProjectIds value)
        {
            return value switch
            {
                UserEventPayloadVariant119ProjectIds.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant119ProjectIds? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant119ProjectIds.All,
                _ => null,
            };
        }
    }
}