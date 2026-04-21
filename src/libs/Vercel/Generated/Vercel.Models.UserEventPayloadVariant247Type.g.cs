
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant247Type
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
    public static class UserEventPayloadVariant247TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant247Type value)
        {
            return value switch
            {
                UserEventPayloadVariant247Type.Blob => "blob",
                UserEventPayloadVariant247Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant247Type.Integration => "integration",
                UserEventPayloadVariant247Type.Postgres => "postgres",
                UserEventPayloadVariant247Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant247Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant247Type.Blob,
                "edge-config" => UserEventPayloadVariant247Type.EdgeConfig,
                "integration" => UserEventPayloadVariant247Type.Integration,
                "postgres" => UserEventPayloadVariant247Type.Postgres,
                "redis" => UserEventPayloadVariant247Type.Redis,
                _ => null,
            };
        }
    }
}