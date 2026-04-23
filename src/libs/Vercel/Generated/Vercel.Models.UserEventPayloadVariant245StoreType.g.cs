
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant245StoreType
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
    public static class UserEventPayloadVariant245StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant245StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant245StoreType.Blob => "blob",
                UserEventPayloadVariant245StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant245StoreType.Integration => "integration",
                UserEventPayloadVariant245StoreType.Postgres => "postgres",
                UserEventPayloadVariant245StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant245StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant245StoreType.Blob,
                "edge-config" => UserEventPayloadVariant245StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant245StoreType.Integration,
                "postgres" => UserEventPayloadVariant245StoreType.Postgres,
                "redis" => UserEventPayloadVariant245StoreType.Redis,
                _ => null,
            };
        }
    }
}