
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant234StoreType
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
    public static class UserEventPayloadVariant234StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant234StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant234StoreType.Blob => "blob",
                UserEventPayloadVariant234StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant234StoreType.Integration => "integration",
                UserEventPayloadVariant234StoreType.Postgres => "postgres",
                UserEventPayloadVariant234StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant234StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant234StoreType.Blob,
                "edge-config" => UserEventPayloadVariant234StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant234StoreType.Integration,
                "postgres" => UserEventPayloadVariant234StoreType.Postgres,
                "redis" => UserEventPayloadVariant234StoreType.Redis,
                _ => null,
            };
        }
    }
}