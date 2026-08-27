
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityRulesetsRateLimitAlgo
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
    public static class GetProjectsResponseVariant1ItemSecurityRulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityRulesetsRateLimitAlgo value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityRulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                GetProjectsResponseVariant1ItemSecurityRulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityRulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetProjectsResponseVariant1ItemSecurityRulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => GetProjectsResponseVariant1ItemSecurityRulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}