
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseEnvItemContentHintVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisRestApiUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseEnvItemContentHintVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseEnvItemContentHintVariant2Type value)
        {
            return value switch
            {
                CreateProjectResponseEnvItemContentHintVariant2Type.RedisRestApiUrl => "redis-rest-api-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseEnvItemContentHintVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-rest-api-url" => CreateProjectResponseEnvItemContentHintVariant2Type.RedisRestApiUrl,
                _ => null,
            };
        }
    }
}