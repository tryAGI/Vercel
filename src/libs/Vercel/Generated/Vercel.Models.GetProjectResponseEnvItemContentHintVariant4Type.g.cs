
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseEnvItemContentHintVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisRestApiReadOnlyToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseEnvItemContentHintVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseEnvItemContentHintVariant4Type value)
        {
            return value switch
            {
                GetProjectResponseEnvItemContentHintVariant4Type.RedisRestApiReadOnlyToken => "redis-rest-api-read-only-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseEnvItemContentHintVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-rest-api-read-only-token" => GetProjectResponseEnvItemContentHintVariant4Type.RedisRestApiReadOnlyToken,
                _ => null,
            };
        }
    }
}