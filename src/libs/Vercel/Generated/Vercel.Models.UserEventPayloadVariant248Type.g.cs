
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant248Type
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
    public static class UserEventPayloadVariant248TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant248Type value)
        {
            return value switch
            {
                UserEventPayloadVariant248Type.Blob => "blob",
                UserEventPayloadVariant248Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant248Type.Integration => "integration",
                UserEventPayloadVariant248Type.Postgres => "postgres",
                UserEventPayloadVariant248Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant248Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant248Type.Blob,
                "edge-config" => UserEventPayloadVariant248Type.EdgeConfig,
                "integration" => UserEventPayloadVariant248Type.Integration,
                "postgres" => UserEventPayloadVariant248Type.Postgres,
                "redis" => UserEventPayloadVariant248Type.Redis,
                _ => null,
            };
        }
    }
}