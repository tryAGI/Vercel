
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseEnvItemContentHintVariant15Type
    {
        /// <summary>
        /// 
        /// </summary>
        FlagsConnectionString,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseEnvItemContentHintVariant15TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseEnvItemContentHintVariant15Type value)
        {
            return value switch
            {
                GetProjectResponseEnvItemContentHintVariant15Type.FlagsConnectionString => "flags-connection-string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseEnvItemContentHintVariant15Type? ToEnum(string value)
        {
            return value switch
            {
                "flags-connection-string" => GetProjectResponseEnvItemContentHintVariant15Type.FlagsConnectionString,
                _ => null,
            };
        }
    }
}