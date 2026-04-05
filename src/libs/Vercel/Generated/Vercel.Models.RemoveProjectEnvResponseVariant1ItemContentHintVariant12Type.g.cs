
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant1ItemContentHintVariant12Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresDatabase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant1ItemContentHintVariant12TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant1ItemContentHintVariant12Type value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant1ItemContentHintVariant12Type.PostgresDatabase => "postgres-database",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant1ItemContentHintVariant12Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-database" => RemoveProjectEnvResponseVariant1ItemContentHintVariant12Type.PostgresDatabase,
                _ => null,
            };
        }
    }
}