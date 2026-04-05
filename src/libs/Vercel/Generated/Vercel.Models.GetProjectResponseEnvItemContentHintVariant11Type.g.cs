
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseEnvItemContentHintVariant11Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresPassword,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseEnvItemContentHintVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseEnvItemContentHintVariant11Type value)
        {
            return value switch
            {
                GetProjectResponseEnvItemContentHintVariant11Type.PostgresPassword => "postgres-password",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseEnvItemContentHintVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-password" => GetProjectResponseEnvItemContentHintVariant11Type.PostgresPassword,
                _ => null,
            };
        }
    }
}