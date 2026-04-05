
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemEnvItemContentHintVariant12Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresDatabase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemEnvItemContentHintVariant12TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemEnvItemContentHintVariant12Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemEnvItemContentHintVariant12Type.PostgresDatabase => "postgres-database",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemEnvItemContentHintVariant12Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-database" => GetProjectsResponseVariant1ItemEnvItemContentHintVariant12Type.PostgresDatabase,
                _ => null,
            };
        }
    }
}