
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant248StoreType
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
    public static class UserEventPayloadVariant248StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant248StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant248StoreType.Blob => "blob",
                UserEventPayloadVariant248StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant248StoreType.Integration => "integration",
                UserEventPayloadVariant248StoreType.Postgres => "postgres",
                UserEventPayloadVariant248StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant248StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant248StoreType.Blob,
                "edge-config" => UserEventPayloadVariant248StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant248StoreType.Integration,
                "postgres" => UserEventPayloadVariant248StoreType.Postgres,
                "redis" => UserEventPayloadVariant248StoreType.Redis,
                _ => null,
            };
        }
    }
}