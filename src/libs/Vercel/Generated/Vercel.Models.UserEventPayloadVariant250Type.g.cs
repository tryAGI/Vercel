
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant250Type
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
    public static class UserEventPayloadVariant250TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant250Type value)
        {
            return value switch
            {
                UserEventPayloadVariant250Type.Blob => "blob",
                UserEventPayloadVariant250Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant250Type.Integration => "integration",
                UserEventPayloadVariant250Type.Postgres => "postgres",
                UserEventPayloadVariant250Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant250Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant250Type.Blob,
                "edge-config" => UserEventPayloadVariant250Type.EdgeConfig,
                "integration" => UserEventPayloadVariant250Type.Integration,
                "postgres" => UserEventPayloadVariant250Type.Postgres,
                "redis" => UserEventPayloadVariant250Type.Redis,
                _ => null,
            };
        }
    }
}