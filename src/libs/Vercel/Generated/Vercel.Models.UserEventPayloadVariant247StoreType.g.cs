
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant247StoreType
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
    public static class UserEventPayloadVariant247StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant247StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant247StoreType.Blob => "blob",
                UserEventPayloadVariant247StoreType.EdgeConfig => "edge-config",
                UserEventPayloadVariant247StoreType.Integration => "integration",
                UserEventPayloadVariant247StoreType.Postgres => "postgres",
                UserEventPayloadVariant247StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant247StoreType? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant247StoreType.Blob,
                "edge-config" => UserEventPayloadVariant247StoreType.EdgeConfig,
                "integration" => UserEventPayloadVariant247StoreType.Integration,
                "postgres" => UserEventPayloadVariant247StoreType.Postgres,
                "redis" => UserEventPayloadVariant247StoreType.Redis,
                _ => null,
            };
        }
    }
}