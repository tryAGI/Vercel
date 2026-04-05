
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant1ContentHintVariant12Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresDatabase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterProjectEnvsResponseVariant1ContentHintVariant12TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant1ContentHintVariant12Type value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant1ContentHintVariant12Type.PostgresDatabase => "postgres-database",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant1ContentHintVariant12Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-database" => FilterProjectEnvsResponseVariant1ContentHintVariant12Type.PostgresDatabase,
                _ => null,
            };
        }
    }
}