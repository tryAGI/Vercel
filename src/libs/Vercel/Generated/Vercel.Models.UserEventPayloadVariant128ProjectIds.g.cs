
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant128ProjectIds
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant128ProjectIdsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant128ProjectIds value)
        {
            return value switch
            {
                UserEventPayloadVariant128ProjectIds.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant128ProjectIds? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant128ProjectIds.All,
                _ => null,
            };
        }
    }
}