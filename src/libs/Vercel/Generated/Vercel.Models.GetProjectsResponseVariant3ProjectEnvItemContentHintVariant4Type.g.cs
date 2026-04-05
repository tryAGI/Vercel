
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectEnvItemContentHintVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisRestApiReadOnlyToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectEnvItemContentHintVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectEnvItemContentHintVariant4Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectEnvItemContentHintVariant4Type.RedisRestApiReadOnlyToken => "redis-rest-api-read-only-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectEnvItemContentHintVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-rest-api-read-only-token" => GetProjectsResponseVariant3ProjectEnvItemContentHintVariant4Type.RedisRestApiReadOnlyToken,
                _ => null,
            };
        }
    }
}