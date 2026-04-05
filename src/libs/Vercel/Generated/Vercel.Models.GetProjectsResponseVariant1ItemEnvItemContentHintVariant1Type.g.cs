
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemEnvItemContentHintVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemEnvItemContentHintVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemEnvItemContentHintVariant1Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemEnvItemContentHintVariant1Type.RedisUrl => "redis-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemEnvItemContentHintVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-url" => GetProjectsResponseVariant1ItemEnvItemContentHintVariant1Type.RedisUrl,
                _ => null,
            };
        }
    }
}