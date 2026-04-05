
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant230StoreType
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
    public static class UserEventPayloadVariant230StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant230StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant230StoreType.Blob => "blob",
                UserEventPayloadVariant230StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant230StoreType.Integration => "integration",
                UserEventPayloadVariant230StoreType.Postgres => "postgres",
                UserEventPayloadVariant230StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant230StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant230StoreType.Blob,
                "edge-config" => UserEventPayloadVariant230StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant230StoreType.Integration,
                "postgres" => UserEventPayloadVariant230StoreType.Postgres,
                "redis" => UserEventPayloadVariant230StoreType.Redis,
                _ => null,
            };
        }
    }
}