
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373TracingSamplingRuleEnv
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
    public static class AutoSDKShared94b26a5607c7a373TracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373TracingSamplingRuleEnv value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373TracingSamplingRuleEnv.Preview => "preview",
                AutoSDKShared94b26a5607c7a373TracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373TracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared94b26a5607c7a373TracingSamplingRuleEnv.Preview,
                "production" => AutoSDKShared94b26a5607c7a373TracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}