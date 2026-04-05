
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseEnvItemContentHintVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisRestApiToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseEnvItemContentHintVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseEnvItemContentHintVariant3Type value)
        {
            return value switch
            {
                CreateProjectResponseEnvItemContentHintVariant3Type.RedisRestApiToken => "redis-rest-api-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseEnvItemContentHintVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-rest-api-token" => CreateProjectResponseEnvItemContentHintVariant3Type.RedisRestApiToken,
                _ => null,
            };
        }
    }
}