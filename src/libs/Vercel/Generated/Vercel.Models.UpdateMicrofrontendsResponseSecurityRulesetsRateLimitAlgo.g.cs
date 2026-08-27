
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseSecurityRulesetsRateLimitAlgo
    {
        /// <summary>
        ///
        /// </summary>
        FixedWindow,
        /// <summary>
        ///
        /// </summary>
        TokenBucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseSecurityRulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseSecurityRulesetsRateLimitAlgo value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseSecurityRulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                UpdateMicrofrontendsResponseSecurityRulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseSecurityRulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => UpdateMicrofrontendsResponseSecurityRulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => UpdateMicrofrontendsResponseSecurityRulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}