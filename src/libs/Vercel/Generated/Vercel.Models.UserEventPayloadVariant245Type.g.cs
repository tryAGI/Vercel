
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant245Type
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
    public static class UserEventPayloadVariant245TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant245Type value)
        {
            return value switch
            {
                UserEventPayloadVariant245Type.Blob => "blob",
                UserEventPayloadVariant245Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant245Type.Integration => "integration",
                UserEventPayloadVariant245Type.Postgres => "postgres",
                UserEventPayloadVariant245Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant245Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant245Type.Blob,
                "edge-config" => UserEventPayloadVariant245Type.EdgeConfig,
                "integration" => UserEventPayloadVariant245Type.Integration,
                "postgres" => UserEventPayloadVariant245Type.Postgres,
                "redis" => UserEventPayloadVariant245Type.Redis,
                _ => null,
            };
        }
    }
}