
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseCreatedContentHintVariant15Type
    {
        /// <summary>
        /// 
        /// </summary>
        FlagsConnectionString,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectEnvResponseCreatedContentHintVariant15TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseCreatedContentHintVariant15Type value)
        {
            return value switch
            {
                CreateProjectEnvResponseCreatedContentHintVariant15Type.FlagsConnectionString => "flags-connection-string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseCreatedContentHintVariant15Type? ToEnum(string value)
        {
            return value switch
            {
                "flags-connection-string" => CreateProjectEnvResponseCreatedContentHintVariant15Type.FlagsConnectionString,
                _ => null,
            };
        }
    }
}