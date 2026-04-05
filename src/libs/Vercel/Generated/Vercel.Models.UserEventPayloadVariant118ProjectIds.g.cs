
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant118ProjectIds
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant118ProjectIdsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant118ProjectIds value)
        {
            return value switch
            {
                UserEventPayloadVariant118ProjectIds.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant118ProjectIds? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant118ProjectIds.All,
                _ => null,
            };
        }
    }
}