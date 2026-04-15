
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant242StoreType
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
    public static class UserEventPayloadVariant242StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant242StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant242StoreType.Blob => "blob",
                UserEventPayloadVariant242StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant242StoreType.Integration => "integration",
                UserEventPayloadVariant242StoreType.Postgres => "postgres",
                UserEventPayloadVariant242StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant242StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant242StoreType.Blob,
                "edge-config" => UserEventPayloadVariant242StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant242StoreType.Integration,
                "postgres" => UserEventPayloadVariant242StoreType.Postgres,
                "redis" => UserEventPayloadVariant242StoreType.Redis,
                _ => null,
            };
        }
    }
}