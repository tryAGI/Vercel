
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant260Type
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
    public static class UserEventPayloadVariant260TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant260Type value)
        {
            return value switch
            {
                UserEventPayloadVariant260Type.Blob => "blob",
                UserEventPayloadVariant260Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant260Type.Integration => "integration",
                UserEventPayloadVariant260Type.Postgres => "postgres",
                UserEventPayloadVariant260Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant260Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant260Type.Blob,
                "edge-config" => UserEventPayloadVariant260Type.EdgeConfig,
                "integration" => UserEventPayloadVariant260Type.Integration,
                "postgres" => UserEventPayloadVariant260Type.Postgres,
                "redis" => UserEventPayloadVariant260Type.Redis,
                _ => null,
            };
        }
    }
}