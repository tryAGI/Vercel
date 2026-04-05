
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant3ContentHintVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant3ContentHintVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant3ContentHintVariant9Type value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant3ContentHintVariant9Type.PostgresUser => "postgres-user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant3ContentHintVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-user" => RemoveProjectEnvResponseVariant3ContentHintVariant9Type.PostgresUser,
                _ => null,
            };
        }
    }
}