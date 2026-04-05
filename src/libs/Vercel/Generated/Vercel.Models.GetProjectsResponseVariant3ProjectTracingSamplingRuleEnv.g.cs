
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectTracingSamplingRuleEnv
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectTracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectTracingSamplingRuleEnv value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectTracingSamplingRuleEnv.Preview => "preview",
                GetProjectsResponseVariant3ProjectTracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectTracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectsResponseVariant3ProjectTracingSamplingRuleEnv.Preview,
                "production" => GetProjectsResponseVariant3ProjectTracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}