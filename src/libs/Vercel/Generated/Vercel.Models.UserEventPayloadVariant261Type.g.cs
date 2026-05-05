
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant261Type
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
    public static class UserEventPayloadVariant261TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant261Type value)
        {
            return value switch
            {
                UserEventPayloadVariant261Type.Blob => "blob",
                UserEventPayloadVariant261Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant261Type.Integration => "integration",
                UserEventPayloadVariant261Type.Postgres => "postgres",
                UserEventPayloadVariant261Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant261Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant261Type.Blob,
                "edge-config" => UserEventPayloadVariant261Type.EdgeConfig,
                "integration" => UserEventPayloadVariant261Type.Integration,
                "postgres" => UserEventPayloadVariant261Type.Postgres,
                "redis" => UserEventPayloadVariant261Type.Redis,
                _ => null,
            };
        }
    }
}