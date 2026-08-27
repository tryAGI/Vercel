
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseSecurityRulesetsRateLimitAlgo
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
    public static class GetProjectResponseSecurityRulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseSecurityRulesetsRateLimitAlgo value)
        {
            return value switch
            {
                GetProjectResponseSecurityRulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                GetProjectResponseSecurityRulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseSecurityRulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetProjectResponseSecurityRulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => GetProjectResponseSecurityRulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}