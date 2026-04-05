
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant10Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant10Type value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant10Type.PostgresHost => "postgres-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-host" => GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant10Type.PostgresHost,
                _ => null,
            };
        }
    }
}