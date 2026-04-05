
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectEnvResponseVariant2ContentHintVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectEnvResponseVariant2ContentHintVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant2ContentHintVariant9Type value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant2ContentHintVariant9Type.PostgresUser => "postgres-user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant2ContentHintVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-user" => GetProjectEnvResponseVariant2ContentHintVariant9Type.PostgresUser,
                _ => null,
            };
        }
    }
}