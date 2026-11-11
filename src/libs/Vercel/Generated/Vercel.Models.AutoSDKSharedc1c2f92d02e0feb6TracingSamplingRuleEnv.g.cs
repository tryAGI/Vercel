
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6TracingSamplingRuleEnv
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
    public static class AutoSDKSharedc1c2f92d02e0feb6TracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6TracingSamplingRuleEnv value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6TracingSamplingRuleEnv.Preview => "preview",
                AutoSDKSharedc1c2f92d02e0feb6TracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6TracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKSharedc1c2f92d02e0feb6TracingSamplingRuleEnv.Preview,
                "production" => AutoSDKSharedc1c2f92d02e0feb6TracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}