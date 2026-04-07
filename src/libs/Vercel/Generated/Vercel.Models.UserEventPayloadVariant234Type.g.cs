
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant234Type
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
    public static class UserEventPayloadVariant234TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant234Type value)
        {
            return value switch
            {
                UserEventPayloadVariant234Type.Blob => "blob",
                UserEventPayloadVariant234Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant234Type.Integration => "integration",
                UserEventPayloadVariant234Type.Postgres => "postgres",
                UserEventPayloadVariant234Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant234Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant234Type.Blob,
                "edge-config" => UserEventPayloadVariant234Type.EdgeConfig,
                "integration" => UserEventPayloadVariant234Type.Integration,
                "postgres" => UserEventPayloadVariant234Type.Postgres,
                "redis" => UserEventPayloadVariant234Type.Redis,
                _ => null,
            };
        }
    }
}