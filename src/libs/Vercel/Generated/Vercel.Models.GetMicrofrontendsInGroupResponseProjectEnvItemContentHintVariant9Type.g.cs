
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUrlNonPooling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant9Type value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant9Type.PostgresUrlNonPooling => "postgres-url-non-pooling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-url-non-pooling" => GetMicrofrontendsInGroupResponseProjectEnvItemContentHintVariant9Type.PostgresUrlNonPooling,
                _ => null,
            };
        }
    }
}