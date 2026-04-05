
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseCreatedContentHintVariant13Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUrlNoSsl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectEnvResponseCreatedContentHintVariant13TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseCreatedContentHintVariant13Type value)
        {
            return value switch
            {
                CreateProjectEnvResponseCreatedContentHintVariant13Type.PostgresUrlNoSsl => "postgres-url-no-ssl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseCreatedContentHintVariant13Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-url-no-ssl" => CreateProjectEnvResponseCreatedContentHintVariant13Type.PostgresUrlNoSsl,
                _ => null,
            };
        }
    }
}