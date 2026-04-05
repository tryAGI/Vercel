
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseEnvItemContentHintVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisRestApiUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseEnvItemContentHintVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseEnvItemContentHintVariant2Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseEnvItemContentHintVariant2Type.RedisRestApiUrl => "redis-rest-api-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseEnvItemContentHintVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-rest-api-url" => UpdateMicrofrontendsResponseEnvItemContentHintVariant2Type.RedisRestApiUrl,
                _ => null,
            };
        }
    }
}