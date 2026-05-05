
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant258StoreType
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
    public static class UserEventPayloadVariant258StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant258StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant258StoreType.Blob => "blob",
                UserEventPayloadVariant258StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant258StoreType.Integration => "integration",
                UserEventPayloadVariant258StoreType.Postgres => "postgres",
                UserEventPayloadVariant258StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant258StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant258StoreType.Blob,
                "edge-config" => UserEventPayloadVariant258StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant258StoreType.Integration,
                "postgres" => UserEventPayloadVariant258StoreType.Postgres,
                "redis" => UserEventPayloadVariant258StoreType.Redis,
                _ => null,
            };
        }
    }
}