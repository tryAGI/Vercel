
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseEnvItemContentHintVariant10Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseEnvItemContentHintVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseEnvItemContentHintVariant10Type value)
        {
            return value switch
            {
                CreateProjectResponseEnvItemContentHintVariant10Type.PostgresHost => "postgres-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseEnvItemContentHintVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-host" => CreateProjectResponseEnvItemContentHintVariant10Type.PostgresHost,
                _ => null,
            };
        }
    }
}