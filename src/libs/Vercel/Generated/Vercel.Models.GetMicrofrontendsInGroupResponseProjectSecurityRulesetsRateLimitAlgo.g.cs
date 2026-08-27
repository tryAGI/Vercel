
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAlgo
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
    public static class GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAlgo value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}