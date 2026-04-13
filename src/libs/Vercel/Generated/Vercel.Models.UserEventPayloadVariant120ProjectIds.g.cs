
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant120ProjectIds
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant120ProjectIdsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant120ProjectIds value)
        {
            return value switch
            {
                UserEventPayloadVariant120ProjectIds.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant120ProjectIds? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant120ProjectIds.All,
                _ => null,
            };
        }
    }
}