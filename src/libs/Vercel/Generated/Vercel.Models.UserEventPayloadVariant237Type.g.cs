
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant237Type
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
    public static class UserEventPayloadVariant237TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant237Type value)
        {
            return value switch
            {
                UserEventPayloadVariant237Type.Blob => "blob",
                UserEventPayloadVariant237Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant237Type.Integration => "integration",
                UserEventPayloadVariant237Type.Postgres => "postgres",
                UserEventPayloadVariant237Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant237Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant237Type.Blob,
                "edge-config" => UserEventPayloadVariant237Type.EdgeConfig,
                "integration" => UserEventPayloadVariant237Type.Integration,
                "postgres" => UserEventPayloadVariant237Type.Postgres,
                "redis" => UserEventPayloadVariant237Type.Redis,
                _ => null,
            };
        }
    }
}