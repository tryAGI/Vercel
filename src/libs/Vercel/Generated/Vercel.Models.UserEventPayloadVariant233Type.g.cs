
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant233Type
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
    public static class UserEventPayloadVariant233TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant233Type value)
        {
            return value switch
            {
                UserEventPayloadVariant233Type.Blob => "blob",
                UserEventPayloadVariant233Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant233Type.Integration => "integration",
                UserEventPayloadVariant233Type.Postgres => "postgres",
                UserEventPayloadVariant233Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant233Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant233Type.Blob,
                "edge-config" => UserEventPayloadVariant233Type.EdgeConfig,
                "integration" => UserEventPayloadVariant233Type.Integration,
                "postgres" => UserEventPayloadVariant233Type.Postgres,
                "redis" => UserEventPayloadVariant233Type.Redis,
                _ => null,
            };
        }
    }
}