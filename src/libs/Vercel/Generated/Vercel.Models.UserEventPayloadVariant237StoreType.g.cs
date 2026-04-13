
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant237StoreType
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
    public static class UserEventPayloadVariant237StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant237StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant237StoreType.Blob => "blob",
                UserEventPayloadVariant237StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant237StoreType.Integration => "integration",
                UserEventPayloadVariant237StoreType.Postgres => "postgres",
                UserEventPayloadVariant237StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant237StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant237StoreType.Blob,
                "edge-config" => UserEventPayloadVariant237StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant237StoreType.Integration,
                "postgres" => UserEventPayloadVariant237StoreType.Postgres,
                "redis" => UserEventPayloadVariant237StoreType.Redis,
                _ => null,
            };
        }
    }
}