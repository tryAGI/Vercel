
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant257Type
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
    public static class UserEventPayloadVariant257TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant257Type value)
        {
            return value switch
            {
                UserEventPayloadVariant257Type.Blob => "blob",
                UserEventPayloadVariant257Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant257Type.Integration => "integration",
                UserEventPayloadVariant257Type.Postgres => "postgres",
                UserEventPayloadVariant257Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant257Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant257Type.Blob,
                "edge-config" => UserEventPayloadVariant257Type.EdgeConfig,
                "integration" => UserEventPayloadVariant257Type.Integration,
                "postgres" => UserEventPayloadVariant257Type.Postgres,
                "redis" => UserEventPayloadVariant257Type.Redis,
                _ => null,
            };
        }
    }
}