
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant236StoreType
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
    public static class UserEventPayloadVariant236StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant236StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant236StoreType.Blob => "blob",
                UserEventPayloadVariant236StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant236StoreType.Integration => "integration",
                UserEventPayloadVariant236StoreType.Postgres => "postgres",
                UserEventPayloadVariant236StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant236StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant236StoreType.Blob,
                "edge-config" => UserEventPayloadVariant236StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant236StoreType.Integration,
                "postgres" => UserEventPayloadVariant236StoreType.Postgres,
                "redis" => UserEventPayloadVariant236StoreType.Redis,
                _ => null,
            };
        }
    }
}