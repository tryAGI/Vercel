
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant235Type
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
    public static class UserEventPayloadVariant235TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant235Type value)
        {
            return value switch
            {
                UserEventPayloadVariant235Type.Blob => "blob",
                UserEventPayloadVariant235Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant235Type.Integration => "integration",
                UserEventPayloadVariant235Type.Postgres => "postgres",
                UserEventPayloadVariant235Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant235Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant235Type.Blob,
                "edge-config" => UserEventPayloadVariant235Type.EdgeConfig,
                "integration" => UserEventPayloadVariant235Type.Integration,
                "postgres" => UserEventPayloadVariant235Type.Postgres,
                "redis" => UserEventPayloadVariant235Type.Redis,
                _ => null,
            };
        }
    }
}