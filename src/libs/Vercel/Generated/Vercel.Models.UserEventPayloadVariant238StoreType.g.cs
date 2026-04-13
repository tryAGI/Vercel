
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant238StoreType
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
    public static class UserEventPayloadVariant238StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant238StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant238StoreType.Blob => "blob",
                UserEventPayloadVariant238StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant238StoreType.Integration => "integration",
                UserEventPayloadVariant238StoreType.Postgres => "postgres",
                UserEventPayloadVariant238StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant238StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant238StoreType.Blob,
                "edge-config" => UserEventPayloadVariant238StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant238StoreType.Integration,
                "postgres" => UserEventPayloadVariant238StoreType.Postgres,
                "redis" => UserEventPayloadVariant238StoreType.Redis,
                _ => null,
            };
        }
    }
}