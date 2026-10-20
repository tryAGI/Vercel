
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afTracingSamplingRuleEnv
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
    public static class AutoSDKShared6bf801e26ecd75afTracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afTracingSamplingRuleEnv value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afTracingSamplingRuleEnv.Preview => "preview",
                AutoSDKShared6bf801e26ecd75afTracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afTracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared6bf801e26ecd75afTracingSamplingRuleEnv.Preview,
                "production" => AutoSDKShared6bf801e26ecd75afTracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}