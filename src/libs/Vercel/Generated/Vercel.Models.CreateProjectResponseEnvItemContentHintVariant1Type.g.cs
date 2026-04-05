
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseEnvItemContentHintVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseEnvItemContentHintVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseEnvItemContentHintVariant1Type value)
        {
            return value switch
            {
                CreateProjectResponseEnvItemContentHintVariant1Type.RedisUrl => "redis-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseEnvItemContentHintVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-url" => CreateProjectResponseEnvItemContentHintVariant1Type.RedisUrl,
                _ => null,
            };
        }
    }
}