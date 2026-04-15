
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant244Type
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
    public static class UserEventPayloadVariant244TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant244Type value)
        {
            return value switch
            {
                UserEventPayloadVariant244Type.Blob => "blob",
                UserEventPayloadVariant244Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant244Type.Integration => "integration",
                UserEventPayloadVariant244Type.Postgres => "postgres",
                UserEventPayloadVariant244Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant244Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant244Type.Blob,
                "edge-config" => UserEventPayloadVariant244Type.EdgeConfig,
                "integration" => UserEventPayloadVariant244Type.Integration,
                "postgres" => UserEventPayloadVariant244Type.Postgres,
                "redis" => UserEventPayloadVariant244Type.Redis,
                _ => null,
            };
        }
    }
}