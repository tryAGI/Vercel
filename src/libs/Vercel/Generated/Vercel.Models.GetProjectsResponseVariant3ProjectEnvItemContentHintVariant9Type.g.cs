
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectEnvItemContentHintVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectEnvItemContentHintVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectEnvItemContentHintVariant9Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectEnvItemContentHintVariant9Type.PostgresUser => "postgres-user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectEnvItemContentHintVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-user" => GetProjectsResponseVariant3ProjectEnvItemContentHintVariant9Type.PostgresUser,
                _ => null,
            };
        }
    }
}