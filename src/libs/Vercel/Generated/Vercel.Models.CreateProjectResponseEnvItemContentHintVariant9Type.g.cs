
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseEnvItemContentHintVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseEnvItemContentHintVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseEnvItemContentHintVariant9Type value)
        {
            return value switch
            {
                CreateProjectResponseEnvItemContentHintVariant9Type.PostgresUser => "postgres-user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseEnvItemContentHintVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-user" => CreateProjectResponseEnvItemContentHintVariant9Type.PostgresUser,
                _ => null,
            };
        }
    }
}