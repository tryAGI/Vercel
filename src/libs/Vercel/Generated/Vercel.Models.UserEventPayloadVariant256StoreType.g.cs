
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant256StoreType
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
    public static class UserEventPayloadVariant256StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant256StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant256StoreType.Blob => "blob",
                UserEventPayloadVariant256StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant256StoreType.Integration => "integration",
                UserEventPayloadVariant256StoreType.Postgres => "postgres",
                UserEventPayloadVariant256StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant256StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant256StoreType.Blob,
                "edge-config" => UserEventPayloadVariant256StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant256StoreType.Integration,
                "postgres" => UserEventPayloadVariant256StoreType.Postgres,
                "redis" => UserEventPayloadVariant256StoreType.Redis,
                _ => null,
            };
        }
    }
}