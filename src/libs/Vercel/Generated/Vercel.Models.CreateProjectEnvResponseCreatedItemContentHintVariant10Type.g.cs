
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseCreatedItemContentHintVariant10Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectEnvResponseCreatedItemContentHintVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseCreatedItemContentHintVariant10Type value)
        {
            return value switch
            {
                CreateProjectEnvResponseCreatedItemContentHintVariant10Type.PostgresHost => "postgres-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseCreatedItemContentHintVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-host" => CreateProjectEnvResponseCreatedItemContentHintVariant10Type.PostgresHost,
                _ => null,
            };
        }
    }
}