
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditProjectEnvResponseContentHintVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisRestApiToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditProjectEnvResponseContentHintVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditProjectEnvResponseContentHintVariant3Type value)
        {
            return value switch
            {
                EditProjectEnvResponseContentHintVariant3Type.RedisRestApiToken => "redis-rest-api-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditProjectEnvResponseContentHintVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-rest-api-token" => EditProjectEnvResponseContentHintVariant3Type.RedisRestApiToken,
                _ => null,
            };
        }
    }
}