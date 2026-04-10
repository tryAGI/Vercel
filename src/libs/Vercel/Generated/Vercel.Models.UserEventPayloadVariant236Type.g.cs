
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant236Type
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
    public static class UserEventPayloadVariant236TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant236Type value)
        {
            return value switch
            {
                UserEventPayloadVariant236Type.Blob => "blob",
                UserEventPayloadVariant236Type.EdgeConfig => "edge-config",
                UserEventPayloadVariant236Type.Integration => "integration",
                UserEventPayloadVariant236Type.Postgres => "postgres",
                UserEventPayloadVariant236Type.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant236Type? ToEnum(string value)
        {
            return value switch
            {
                "blob" => UserEventPayloadVariant236Type.Blob,
                "edge-config" => UserEventPayloadVariant236Type.EdgeConfig,
                "integration" => UserEventPayloadVariant236Type.Integration,
                "postgres" => UserEventPayloadVariant236Type.Postgres,
                "redis" => UserEventPayloadVariant236Type.Redis,
                _ => null,
            };
        }
    }
}