
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityRulesetsRateLimitAlgo
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
    public static class GetProjectsResponseVariant2ProjectSecurityRulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityRulesetsRateLimitAlgo value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityRulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                GetProjectsResponseVariant2ProjectSecurityRulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityRulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetProjectsResponseVariant2ProjectSecurityRulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => GetProjectsResponseVariant2ProjectSecurityRulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}