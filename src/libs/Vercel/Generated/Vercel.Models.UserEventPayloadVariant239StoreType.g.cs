
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant239StoreType
    {
        /// <summary>
        /// 
        /// </summary>
        Blob,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfig,
        /// <summary>
        /// 
        /// </summary>
        Integration,
        /// <summary>
        /// 
        /// </summary>
        Postgres,
        /// <summary>
        /// 
        /// </summary>
        Redis,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant239StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant239StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant239StoreType.Blob => "blob",
                UserEventPayloadVariant239StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant239StoreType.Integration => "integration",
                UserEventPayloadVariant239StoreType.Postgres => "postgres",
                UserEventPayloadVariant239StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant239StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant239StoreType.Blob,
                "edge-config" => UserEventPayloadVariant239StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant239StoreType.Integration,
                "postgres" => UserEventPayloadVariant239StoreType.Postgres,
                "redis" => UserEventPayloadVariant239StoreType.Redis,
                _ => null,
            };
        }
    }
}