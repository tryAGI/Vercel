
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseEnvItemContentHintVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseEnvItemContentHintVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseEnvItemContentHintVariant9Type value)
        {
            return value switch
            {
                UpdateProjectResponseEnvItemContentHintVariant9Type.PostgresUser => "postgres-user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseEnvItemContentHintVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-user" => UpdateProjectResponseEnvItemContentHintVariant9Type.PostgresUser,
                _ => null,
            };
        }
    }
}