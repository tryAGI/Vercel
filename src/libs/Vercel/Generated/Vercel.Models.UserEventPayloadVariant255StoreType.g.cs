
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant255StoreType
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
    public static class UserEventPayloadVariant255StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant255StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant255StoreType.Blob => "blob",
                UserEventPayloadVariant255StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant255StoreType.Integration => "integration",
                UserEventPayloadVariant255StoreType.Postgres => "postgres",
                UserEventPayloadVariant255StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant255StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant255StoreType.Blob,
                "edge-config" => UserEventPayloadVariant255StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant255StoreType.Integration,
                "postgres" => UserEventPayloadVariant255StoreType.Postgres,
                "redis" => UserEventPayloadVariant255StoreType.Redis,
                _ => null,
            };
        }
    }
}