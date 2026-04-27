
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant251Type
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
    public static class UserEventPayloadVariant251TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant251Type value)
        {
            return value switch
            {
                UserEventPayloadVariant251Type.Blob => "blob",
                UserEventPayloadVariant251Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant251Type.Integration => "integration",
                UserEventPayloadVariant251Type.Postgres => "postgres",
                UserEventPayloadVariant251Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant251Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant251Type.Blob,
                "edge-config" => UserEventPayloadVariant251Type.EdgeConfig,
                "integration" => UserEventPayloadVariant251Type.Integration,
                "postgres" => UserEventPayloadVariant251Type.Postgres,
                "redis" => UserEventPayloadVariant251Type.Redis,
                _ => null,
            };
        }
    }
}