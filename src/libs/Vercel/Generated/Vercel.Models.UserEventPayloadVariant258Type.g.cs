
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant258Type
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
    public static class UserEventPayloadVariant258TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant258Type value)
        {
            return value switch
            {
                UserEventPayloadVariant258Type.Blob => "blob",
                UserEventPayloadVariant258Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant258Type.Integration => "integration",
                UserEventPayloadVariant258Type.Postgres => "postgres",
                UserEventPayloadVariant258Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant258Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant258Type.Blob,
                "edge-config" => UserEventPayloadVariant258Type.EdgeConfig,
                "integration" => UserEventPayloadVariant258Type.Integration,
                "postgres" => UserEventPayloadVariant258Type.Postgres,
                "redis" => UserEventPayloadVariant258Type.Redis,
                _ => null,
            };
        }
    }
}