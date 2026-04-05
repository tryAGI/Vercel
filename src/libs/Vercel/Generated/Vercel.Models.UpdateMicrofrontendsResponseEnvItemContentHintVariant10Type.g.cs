
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseEnvItemContentHintVariant10Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseEnvItemContentHintVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseEnvItemContentHintVariant10Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseEnvItemContentHintVariant10Type.PostgresHost => "postgres-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseEnvItemContentHintVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-host" => UpdateMicrofrontendsResponseEnvItemContentHintVariant10Type.PostgresHost,
                _ => null,
            };
        }
    }
}