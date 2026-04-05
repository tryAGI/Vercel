
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseEnvItemContentHintVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresPrismaUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseEnvItemContentHintVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseEnvItemContentHintVariant8Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseEnvItemContentHintVariant8Type.PostgresPrismaUrl => "postgres-prisma-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseEnvItemContentHintVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-prisma-url" => UpdateMicrofrontendsResponseEnvItemContentHintVariant8Type.PostgresPrismaUrl,
                _ => null,
            };
        }
    }
}