
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemEnvItemContentHintVariant11Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresPassword,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemEnvItemContentHintVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemEnvItemContentHintVariant11Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemEnvItemContentHintVariant11Type.PostgresPassword => "postgres-password",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemEnvItemContentHintVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-password" => GetProjectsResponseVariant1ItemEnvItemContentHintVariant11Type.PostgresPassword,
                _ => null,
            };
        }
    }
}