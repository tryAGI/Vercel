
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1134f969ff3cc06cTracingSamplingRuleEnv
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
    public static class AutoSDKShared1134f969ff3cc06cTracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1134f969ff3cc06cTracingSamplingRuleEnv value)
        {
            return value switch
            {
                AutoSDKShared1134f969ff3cc06cTracingSamplingRuleEnv.Preview => "preview",
                AutoSDKShared1134f969ff3cc06cTracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1134f969ff3cc06cTracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared1134f969ff3cc06cTracingSamplingRuleEnv.Preview,
                "production" => AutoSDKShared1134f969ff3cc06cTracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}