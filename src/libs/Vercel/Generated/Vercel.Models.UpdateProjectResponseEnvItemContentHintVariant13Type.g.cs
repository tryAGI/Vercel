
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseEnvItemContentHintVariant13Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUrlNoSsl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseEnvItemContentHintVariant13TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseEnvItemContentHintVariant13Type value)
        {
            return value switch
            {
                UpdateProjectResponseEnvItemContentHintVariant13Type.PostgresUrlNoSsl => "postgres-url-no-ssl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseEnvItemContentHintVariant13Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-url-no-ssl" => UpdateProjectResponseEnvItemContentHintVariant13Type.PostgresUrlNoSsl,
                _ => null,
            };
        }
    }
}