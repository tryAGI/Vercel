
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant1ItemContentHintVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresPrismaUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant1ItemContentHintVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant1ItemContentHintVariant8Type value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant1ItemContentHintVariant8Type.PostgresPrismaUrl => "postgres-prisma-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant1ItemContentHintVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-prisma-url" => RemoveProjectEnvResponseVariant1ItemContentHintVariant8Type.PostgresPrismaUrl,
                _ => null,
            };
        }
    }
}