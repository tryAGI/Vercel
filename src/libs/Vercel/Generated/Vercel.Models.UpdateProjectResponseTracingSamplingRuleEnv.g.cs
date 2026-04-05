
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseTracingSamplingRuleEnv
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
    public static class UpdateProjectResponseTracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseTracingSamplingRuleEnv value)
        {
            return value switch
            {
                UpdateProjectResponseTracingSamplingRuleEnv.Preview => "preview",
                UpdateProjectResponseTracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseTracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateProjectResponseTracingSamplingRuleEnv.Preview,
                "production" => UpdateProjectResponseTracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}