
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectSecurityRulesetsRateLimitAlgo
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
    public static class GetProjectsResponseVariant3ProjectSecurityRulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectSecurityRulesetsRateLimitAlgo value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectSecurityRulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                GetProjectsResponseVariant3ProjectSecurityRulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectSecurityRulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetProjectsResponseVariant3ProjectSecurityRulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => GetProjectsResponseVariant3ProjectSecurityRulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}