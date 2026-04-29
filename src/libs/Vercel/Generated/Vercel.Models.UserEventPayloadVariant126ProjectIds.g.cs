
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant126ProjectIds
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant126ProjectIdsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant126ProjectIds value)
        {
            return value switch
            {
                UserEventPayloadVariant126ProjectIds.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant126ProjectIds? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant126ProjectIds.All,
                _ => null,
            };
        }
    }
}