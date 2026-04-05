
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseCreatedContentHintVariant11Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresPassword,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectEnvResponseCreatedContentHintVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseCreatedContentHintVariant11Type value)
        {
            return value switch
            {
                CreateProjectEnvResponseCreatedContentHintVariant11Type.PostgresPassword => "postgres-password",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseCreatedContentHintVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-password" => CreateProjectEnvResponseCreatedContentHintVariant11Type.PostgresPassword,
                _ => null,
            };
        }
    }
}