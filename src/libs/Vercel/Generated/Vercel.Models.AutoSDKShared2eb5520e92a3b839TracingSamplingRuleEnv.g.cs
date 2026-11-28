
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2eb5520e92a3b839TracingSamplingRuleEnv
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
    public static class AutoSDKShared2eb5520e92a3b839TracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2eb5520e92a3b839TracingSamplingRuleEnv value)
        {
            return value switch
            {
                AutoSDKShared2eb5520e92a3b839TracingSamplingRuleEnv.Preview => "preview",
                AutoSDKShared2eb5520e92a3b839TracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2eb5520e92a3b839TracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared2eb5520e92a3b839TracingSamplingRuleEnv.Preview,
                "production" => AutoSDKShared2eb5520e92a3b839TracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}