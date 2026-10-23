
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared52fb994527107e75TracingSamplingRuleEnv
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
    public static class AutoSDKShared52fb994527107e75TracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared52fb994527107e75TracingSamplingRuleEnv value)
        {
            return value switch
            {
                AutoSDKShared52fb994527107e75TracingSamplingRuleEnv.Preview => "preview",
                AutoSDKShared52fb994527107e75TracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared52fb994527107e75TracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared52fb994527107e75TracingSamplingRuleEnv.Preview,
                "production" => AutoSDKShared52fb994527107e75TracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}