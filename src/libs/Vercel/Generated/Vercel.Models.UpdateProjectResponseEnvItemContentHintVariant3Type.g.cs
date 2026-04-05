
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseEnvItemContentHintVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisRestApiToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseEnvItemContentHintVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseEnvItemContentHintVariant3Type value)
        {
            return value switch
            {
                UpdateProjectResponseEnvItemContentHintVariant3Type.RedisRestApiToken => "redis-rest-api-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseEnvItemContentHintVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-rest-api-token" => UpdateProjectResponseEnvItemContentHintVariant3Type.RedisRestApiToken,
                _ => null,
            };
        }
    }
}