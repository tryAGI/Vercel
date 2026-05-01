
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant257StoreType
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
    public static class UserEventPayloadVariant257StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant257StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant257StoreType.Blob => "blob",
                UserEventPayloadVariant257StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant257StoreType.Integration => "integration",
                UserEventPayloadVariant257StoreType.Postgres => "postgres",
                UserEventPayloadVariant257StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant257StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant257StoreType.Blob,
                "edge-config" => UserEventPayloadVariant257StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant257StoreType.Integration,
                "postgres" => UserEventPayloadVariant257StoreType.Postgres,
                "redis" => UserEventPayloadVariant257StoreType.Redis,
                _ => null,
            };
        }
    }
}