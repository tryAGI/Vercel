
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51TracingSamplingRuleEnv
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
    public static class AutoSDKSharedea12f8422dc06e51TracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51TracingSamplingRuleEnv value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51TracingSamplingRuleEnv.Preview => "preview",
                AutoSDKSharedea12f8422dc06e51TracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51TracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKSharedea12f8422dc06e51TracingSamplingRuleEnv.Preview,
                "production" => AutoSDKSharedea12f8422dc06e51TracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}