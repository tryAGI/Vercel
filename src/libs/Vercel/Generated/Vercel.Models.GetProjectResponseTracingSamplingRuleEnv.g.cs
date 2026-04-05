
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseTracingSamplingRuleEnv
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
    public static class GetProjectResponseTracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTracingSamplingRuleEnv value)
        {
            return value switch
            {
                GetProjectResponseTracingSamplingRuleEnv.Preview => "preview",
                GetProjectResponseTracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectResponseTracingSamplingRuleEnv.Preview,
                "production" => GetProjectResponseTracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}