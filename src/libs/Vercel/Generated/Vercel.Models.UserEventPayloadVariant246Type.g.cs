
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant246Type
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
    public static class UserEventPayloadVariant246TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant246Type value)
        {
            return value switch
            {
                UserEventPayloadVariant246Type.Blob => "blob",
                UserEventPayloadVariant246Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant246Type.Integration => "integration",
                UserEventPayloadVariant246Type.Postgres => "postgres",
                UserEventPayloadVariant246Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant246Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant246Type.Blob,
                "edge-config" => UserEventPayloadVariant246Type.EdgeConfig,
                "integration" => UserEventPayloadVariant246Type.Integration,
                "postgres" => UserEventPayloadVariant246Type.Postgres,
                "redis" => UserEventPayloadVariant246Type.Redis,
                _ => null,
            };
        }
    }
}