
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant254StoreType
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
    public static class UserEventPayloadVariant254StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant254StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant254StoreType.Blob => "blob",
                UserEventPayloadVariant254StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant254StoreType.Integration => "integration",
                UserEventPayloadVariant254StoreType.Postgres => "postgres",
                UserEventPayloadVariant254StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant254StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant254StoreType.Blob,
                "edge-config" => UserEventPayloadVariant254StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant254StoreType.Integration,
                "postgres" => UserEventPayloadVariant254StoreType.Postgres,
                "redis" => UserEventPayloadVariant254StoreType.Redis,
                _ => null,
            };
        }
    }
}