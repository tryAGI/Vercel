
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseCreatedItemContentHintVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisRestApiToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectEnvResponseCreatedItemContentHintVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseCreatedItemContentHintVariant3Type value)
        {
            return value switch
            {
                CreateProjectEnvResponseCreatedItemContentHintVariant3Type.RedisRestApiToken => "redis-rest-api-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseCreatedItemContentHintVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-rest-api-token" => CreateProjectEnvResponseCreatedItemContentHintVariant3Type.RedisRestApiToken,
                _ => null,
            };
        }
    }
}