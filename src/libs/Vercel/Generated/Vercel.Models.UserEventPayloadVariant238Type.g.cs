
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant238Type
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
    public static class UserEventPayloadVariant238TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant238Type value)
        {
            return value switch
            {
                UserEventPayloadVariant238Type.Blob => "blob",
                UserEventPayloadVariant238Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant238Type.Integration => "integration",
                UserEventPayloadVariant238Type.Postgres => "postgres",
                UserEventPayloadVariant238Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant238Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant238Type.Blob,
                "edge-config" => UserEventPayloadVariant238Type.EdgeConfig,
                "integration" => UserEventPayloadVariant238Type.Integration,
                "postgres" => UserEventPayloadVariant238Type.Postgres,
                "redis" => UserEventPayloadVariant238Type.Redis,
                _ => null,
            };
        }
    }
}