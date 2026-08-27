
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectResponseSecurityRulesetsRateLimitAlgo
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
    public static class UpdateProjectResponseSecurityRulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseSecurityRulesetsRateLimitAlgo value)
        {
            return value switch
            {
                UpdateProjectResponseSecurityRulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                UpdateProjectResponseSecurityRulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseSecurityRulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => UpdateProjectResponseSecurityRulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => UpdateProjectResponseSecurityRulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}