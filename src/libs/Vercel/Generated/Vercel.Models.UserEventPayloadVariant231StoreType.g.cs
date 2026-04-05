
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant231StoreType
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
    public static class UserEventPayloadVariant231StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant231StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant231StoreType.Blob => "blob",
                UserEventPayloadVariant231StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant231StoreType.Integration => "integration",
                UserEventPayloadVariant231StoreType.Postgres => "postgres",
                UserEventPayloadVariant231StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant231StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant231StoreType.Blob,
                "edge-config" => UserEventPayloadVariant231StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant231StoreType.Integration,
                "postgres" => UserEventPayloadVariant231StoreType.Postgres,
                "redis" => UserEventPayloadVariant231StoreType.Redis,
                _ => null,
            };
        }
    }
}