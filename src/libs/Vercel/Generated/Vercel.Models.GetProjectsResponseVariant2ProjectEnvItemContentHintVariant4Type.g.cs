
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectEnvItemContentHintVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisRestApiReadOnlyToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectEnvItemContentHintVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectEnvItemContentHintVariant4Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectEnvItemContentHintVariant4Type.RedisRestApiReadOnlyToken => "redis-rest-api-read-only-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectEnvItemContentHintVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-rest-api-read-only-token" => GetProjectsResponseVariant2ProjectEnvItemContentHintVariant4Type.RedisRestApiReadOnlyToken,
                _ => null,
            };
        }
    }
}