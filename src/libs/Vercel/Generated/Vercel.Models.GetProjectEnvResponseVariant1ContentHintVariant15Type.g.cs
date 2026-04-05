
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectEnvResponseVariant1ContentHintVariant15Type
    {
        /// <summary>
        /// 
        /// </summary>
        FlagsConnectionString,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectEnvResponseVariant1ContentHintVariant15TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant1ContentHintVariant15Type value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant1ContentHintVariant15Type.FlagsConnectionString => "flags-connection-string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant1ContentHintVariant15Type? ToEnum(string value)
        {
            return value switch
            {
                "flags-connection-string" => GetProjectEnvResponseVariant1ContentHintVariant15Type.FlagsConnectionString,
                _ => null,
            };
        }
    }
}