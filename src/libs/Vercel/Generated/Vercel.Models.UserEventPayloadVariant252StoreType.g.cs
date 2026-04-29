
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant252StoreType
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
    public static class UserEventPayloadVariant252StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant252StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant252StoreType.Blob => "blob",
                UserEventPayloadVariant252StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant252StoreType.Integration => "integration",
                UserEventPayloadVariant252StoreType.Postgres => "postgres",
                UserEventPayloadVariant252StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant252StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant252StoreType.Blob,
                "edge-config" => UserEventPayloadVariant252StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant252StoreType.Integration,
                "postgres" => UserEventPayloadVariant252StoreType.Postgres,
                "redis" => UserEventPayloadVariant252StoreType.Redis,
                _ => null,
            };
        }
    }
}