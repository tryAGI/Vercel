
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant233StoreType
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
    public static class UserEventPayloadVariant233StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant233StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant233StoreType.Blob => "blob",
                UserEventPayloadVariant233StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant233StoreType.Integration => "integration",
                UserEventPayloadVariant233StoreType.Postgres => "postgres",
                UserEventPayloadVariant233StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant233StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant233StoreType.Blob,
                "edge-config" => UserEventPayloadVariant233StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant233StoreType.Integration,
                "postgres" => UserEventPayloadVariant233StoreType.Postgres,
                "redis" => UserEventPayloadVariant233StoreType.Redis,
                _ => null,
            };
        }
    }
}