
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant244StoreType
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
    public static class UserEventPayloadVariant244StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant244StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant244StoreType.Blob => "blob",
                UserEventPayloadVariant244StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant244StoreType.Integration => "integration",
                UserEventPayloadVariant244StoreType.Postgres => "postgres",
                UserEventPayloadVariant244StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant244StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant244StoreType.Blob,
                "edge-config" => UserEventPayloadVariant244StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant244StoreType.Integration,
                "postgres" => UserEventPayloadVariant244StoreType.Postgres,
                "redis" => UserEventPayloadVariant244StoreType.Redis,
                _ => null,
            };
        }
    }
}