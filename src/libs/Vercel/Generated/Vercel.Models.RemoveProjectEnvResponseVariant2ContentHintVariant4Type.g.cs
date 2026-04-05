
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant2ContentHintVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisRestApiReadOnlyToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant2ContentHintVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant2ContentHintVariant4Type value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant2ContentHintVariant4Type.RedisRestApiReadOnlyToken => "redis-rest-api-read-only-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant2ContentHintVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-rest-api-read-only-token" => RemoveProjectEnvResponseVariant2ContentHintVariant4Type.RedisRestApiReadOnlyToken,
                _ => null,
            };
        }
    }
}