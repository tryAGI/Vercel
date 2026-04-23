
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant246StoreType
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
    public static class UserEventPayloadVariant246StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant246StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant246StoreType.Blob => "blob",
                UserEventPayloadVariant246StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant246StoreType.Integration => "integration",
                UserEventPayloadVariant246StoreType.Postgres => "postgres",
                UserEventPayloadVariant246StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant246StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant246StoreType.Blob,
                "edge-config" => UserEventPayloadVariant246StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant246StoreType.Integration,
                "postgres" => UserEventPayloadVariant246StoreType.Postgres,
                "redis" => UserEventPayloadVariant246StoreType.Redis,
                _ => null,
            };
        }
    }
}