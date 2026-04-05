
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectEnvItemContentHintVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisRestApiUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectEnvItemContentHintVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectEnvItemContentHintVariant2Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectEnvItemContentHintVariant2Type.RedisRestApiUrl => "redis-rest-api-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectEnvItemContentHintVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-rest-api-url" => GetProjectsResponseVariant2ProjectEnvItemContentHintVariant2Type.RedisRestApiUrl,
                _ => null,
            };
        }
    }
}