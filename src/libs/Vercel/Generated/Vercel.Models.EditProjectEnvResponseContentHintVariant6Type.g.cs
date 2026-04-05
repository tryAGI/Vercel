
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditProjectEnvResponseContentHintVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditProjectEnvResponseContentHintVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditProjectEnvResponseContentHintVariant6Type value)
        {
            return value switch
            {
                EditProjectEnvResponseContentHintVariant6Type.PostgresUrl => "postgres-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditProjectEnvResponseContentHintVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-url" => EditProjectEnvResponseContentHintVariant6Type.PostgresUrl,
                _ => null,
            };
        }
    }
}