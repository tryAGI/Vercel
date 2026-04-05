
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemEnvItemContentHintVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresPrismaUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemEnvItemContentHintVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemEnvItemContentHintVariant8Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemEnvItemContentHintVariant8Type.PostgresPrismaUrl => "postgres-prisma-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemEnvItemContentHintVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-prisma-url" => GetProjectsResponseVariant1ItemEnvItemContentHintVariant8Type.PostgresPrismaUrl,
                _ => null,
            };
        }
    }
}