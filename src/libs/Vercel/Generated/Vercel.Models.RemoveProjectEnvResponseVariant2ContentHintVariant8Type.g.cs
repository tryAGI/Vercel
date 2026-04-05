
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant2ContentHintVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresPrismaUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant2ContentHintVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant2ContentHintVariant8Type value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant2ContentHintVariant8Type.PostgresPrismaUrl => "postgres-prisma-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant2ContentHintVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-prisma-url" => RemoveProjectEnvResponseVariant2ContentHintVariant8Type.PostgresPrismaUrl,
                _ => null,
            };
        }
    }
}