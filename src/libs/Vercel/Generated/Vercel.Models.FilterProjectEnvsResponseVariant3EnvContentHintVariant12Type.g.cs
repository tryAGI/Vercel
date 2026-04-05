
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant3EnvContentHintVariant12Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresDatabase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterProjectEnvsResponseVariant3EnvContentHintVariant12TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant3EnvContentHintVariant12Type value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant3EnvContentHintVariant12Type.PostgresDatabase => "postgres-database",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant3EnvContentHintVariant12Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-database" => FilterProjectEnvsResponseVariant3EnvContentHintVariant12Type.PostgresDatabase,
                _ => null,
            };
        }
    }
}