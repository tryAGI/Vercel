
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant259Type
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
    public static class UserEventPayloadVariant259TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant259Type value)
        {
            return value switch
            {
                UserEventPayloadVariant259Type.Blob => "blob",
                UserEventPayloadVariant259Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant259Type.Integration => "integration",
                UserEventPayloadVariant259Type.Postgres => "postgres",
                UserEventPayloadVariant259Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant259Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant259Type.Blob,
                "edge-config" => UserEventPayloadVariant259Type.EdgeConfig,
                "integration" => UserEventPayloadVariant259Type.Integration,
                "postgres" => UserEventPayloadVariant259Type.Postgres,
                "redis" => UserEventPayloadVariant259Type.Redis,
                _ => null,
            };
        }
    }
}