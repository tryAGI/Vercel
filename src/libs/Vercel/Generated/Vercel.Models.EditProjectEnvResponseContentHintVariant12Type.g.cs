
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditProjectEnvResponseContentHintVariant12Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresDatabase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditProjectEnvResponseContentHintVariant12TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditProjectEnvResponseContentHintVariant12Type value)
        {
            return value switch
            {
                EditProjectEnvResponseContentHintVariant12Type.PostgresDatabase => "postgres-database",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditProjectEnvResponseContentHintVariant12Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-database" => EditProjectEnvResponseContentHintVariant12Type.PostgresDatabase,
                _ => null,
            };
        }
    }
}