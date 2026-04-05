
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseEnvItemContentHintVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisRestApiToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseEnvItemContentHintVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseEnvItemContentHintVariant3Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseEnvItemContentHintVariant3Type.RedisRestApiToken => "redis-rest-api-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseEnvItemContentHintVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-rest-api-token" => UpdateMicrofrontendsResponseEnvItemContentHintVariant3Type.RedisRestApiToken,
                _ => null,
            };
        }
    }
}