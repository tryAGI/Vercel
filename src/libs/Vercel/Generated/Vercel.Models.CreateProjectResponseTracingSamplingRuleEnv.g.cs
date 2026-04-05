
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseTracingSamplingRuleEnv
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
    public static class CreateProjectResponseTracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTracingSamplingRuleEnv value)
        {
            return value switch
            {
                CreateProjectResponseTracingSamplingRuleEnv.Preview => "preview",
                CreateProjectResponseTracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateProjectResponseTracingSamplingRuleEnv.Preview,
                "production" => CreateProjectResponseTracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}