
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant249Type
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
    public static class UserEventPayloadVariant249TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant249Type value)
        {
            return value switch
            {
                UserEventPayloadVariant249Type.Blob => "blob",
                UserEventPayloadVariant249Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant249Type.Integration => "integration",
                UserEventPayloadVariant249Type.Postgres => "postgres",
                UserEventPayloadVariant249Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant249Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant249Type.Blob,
                "edge-config" => UserEventPayloadVariant249Type.EdgeConfig,
                "integration" => UserEventPayloadVariant249Type.Integration,
                "postgres" => UserEventPayloadVariant249Type.Postgres,
                "redis" => UserEventPayloadVariant249Type.Redis,
                _ => null,
            };
        }
    }
}