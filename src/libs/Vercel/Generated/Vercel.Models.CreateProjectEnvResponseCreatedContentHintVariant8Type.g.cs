
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseCreatedContentHintVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresPrismaUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectEnvResponseCreatedContentHintVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseCreatedContentHintVariant8Type value)
        {
            return value switch
            {
                CreateProjectEnvResponseCreatedContentHintVariant8Type.PostgresPrismaUrl => "postgres-prisma-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseCreatedContentHintVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-prisma-url" => CreateProjectEnvResponseCreatedContentHintVariant8Type.PostgresPrismaUrl,
                _ => null,
            };
        }
    }
}