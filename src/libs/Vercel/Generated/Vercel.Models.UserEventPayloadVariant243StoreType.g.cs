
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant243StoreType
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
    public static class UserEventPayloadVariant243StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant243StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant243StoreType.Blob => "blob",
                UserEventPayloadVariant243StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant243StoreType.Integration => "integration",
                UserEventPayloadVariant243StoreType.Postgres => "postgres",
                UserEventPayloadVariant243StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant243StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant243StoreType.Blob,
                "edge-config" => UserEventPayloadVariant243StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant243StoreType.Integration,
                "postgres" => UserEventPayloadVariant243StoreType.Postgres,
                "redis" => UserEventPayloadVariant243StoreType.Redis,
                _ => null,
            };
        }
    }
}