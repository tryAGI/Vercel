
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Environment to apply sampling to
    /// </summary>
    public enum UpdateProjectRequestTracingSamplingRuleEnv
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
    public static class UpdateProjectRequestTracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestTracingSamplingRuleEnv value)
        {
            return value switch
            {
                UpdateProjectRequestTracingSamplingRuleEnv.Preview => "preview",
                UpdateProjectRequestTracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestTracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateProjectRequestTracingSamplingRuleEnv.Preview,
                "production" => UpdateProjectRequestTracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}