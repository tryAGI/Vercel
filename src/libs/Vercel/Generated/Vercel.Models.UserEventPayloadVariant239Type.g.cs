
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant239Type
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
    public static class UserEventPayloadVariant239TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant239Type value)
        {
            return value switch
            {
                UserEventPayloadVariant239Type.Blob => "blob",
                UserEventPayloadVariant239Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant239Type.Integration => "integration",
                UserEventPayloadVariant239Type.Postgres => "postgres",
                UserEventPayloadVariant239Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant239Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant239Type.Blob,
                "edge-config" => UserEventPayloadVariant239Type.EdgeConfig,
                "integration" => UserEventPayloadVariant239Type.Integration,
                "postgres" => UserEventPayloadVariant239Type.Postgres,
                "redis" => UserEventPayloadVariant239Type.Redis,
                _ => null,
            };
        }
    }
}