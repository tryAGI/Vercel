
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant240Type
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
    public static class UserEventPayloadVariant240TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant240Type value)
        {
            return value switch
            {
                UserEventPayloadVariant240Type.Blob => "blob",
                UserEventPayloadVariant240Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant240Type.Integration => "integration",
                UserEventPayloadVariant240Type.Postgres => "postgres",
                UserEventPayloadVariant240Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant240Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant240Type.Blob,
                "edge-config" => UserEventPayloadVariant240Type.EdgeConfig,
                "integration" => UserEventPayloadVariant240Type.Integration,
                "postgres" => UserEventPayloadVariant240Type.Postgres,
                "redis" => UserEventPayloadVariant240Type.Redis,
                _ => null,
            };
        }
    }
}