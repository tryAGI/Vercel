
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseEnvItemContentHintVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseEnvItemContentHintVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseEnvItemContentHintVariant1Type value)
        {
            return value switch
            {
                GetProjectResponseEnvItemContentHintVariant1Type.RedisUrl => "redis-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseEnvItemContentHintVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-url" => GetProjectResponseEnvItemContentHintVariant1Type.RedisUrl,
                _ => null,
            };
        }
    }
}