
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant255Type
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
    public static class UserEventPayloadVariant255TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant255Type value)
        {
            return value switch
            {
                UserEventPayloadVariant255Type.Blob => "blob",
                UserEventPayloadVariant255Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant255Type.Integration => "integration",
                UserEventPayloadVariant255Type.Postgres => "postgres",
                UserEventPayloadVariant255Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant255Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant255Type.Blob,
                "edge-config" => UserEventPayloadVariant255Type.EdgeConfig,
                "integration" => UserEventPayloadVariant255Type.Integration,
                "postgres" => UserEventPayloadVariant255Type.Postgres,
                "redis" => UserEventPayloadVariant255Type.Redis,
                _ => null,
            };
        }
    }
}