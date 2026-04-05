
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseCreatedItemContentHintVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisRestApiReadOnlyToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectEnvResponseCreatedItemContentHintVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseCreatedItemContentHintVariant4Type value)
        {
            return value switch
            {
                CreateProjectEnvResponseCreatedItemContentHintVariant4Type.RedisRestApiReadOnlyToken => "redis-rest-api-read-only-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseCreatedItemContentHintVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-rest-api-read-only-token" => CreateProjectEnvResponseCreatedItemContentHintVariant4Type.RedisRestApiReadOnlyToken,
                _ => null,
            };
        }
    }
}