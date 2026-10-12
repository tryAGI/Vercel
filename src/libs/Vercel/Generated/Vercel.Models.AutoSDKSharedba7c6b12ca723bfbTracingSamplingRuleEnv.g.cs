
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbTracingSamplingRuleEnv
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
    public static class AutoSDKSharedba7c6b12ca723bfbTracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbTracingSamplingRuleEnv value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbTracingSamplingRuleEnv.Preview => "preview",
                AutoSDKSharedba7c6b12ca723bfbTracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbTracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKSharedba7c6b12ca723bfbTracingSamplingRuleEnv.Preview,
                "production" => AutoSDKSharedba7c6b12ca723bfbTracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}